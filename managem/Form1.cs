using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using PathIO = System.IO.Path; // Créez un alias pour System.IO.Path
using System.Collections;

namespace managem
{
    public partial class Form1 : Form
    {
        private string originalPdfFilePath;
        private string tempPdfFilePath;
        private ArrayList matriculesList;
        // Modèle de l'expression régulière pour chercher un matricule de 7 caractères
        private const string regexPattern = @"\b\d{6}[a-zA-Z]\b";

        public Form1()
        {
            InitializeComponent();
            matriculesList = new ArrayList();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                originalPdfFilePath = opf.FileName;
                lblpath.Text = originalPdfFilePath;
                axAcroPDF1.src = originalPdfFilePath;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_matricules_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_chercher_matricules_Click(object sender, EventArgs e)
        {
            // Supprimer les anciens matricules
            matriculesList.Clear();
            // Diviser le texte du TextBox en matricules de 7 caractères et les stocker dans l'ArrayList
            for (int i = 0; i < txt_matricules.Text.Length; i += 7)
            {
                if (i + 7 <= txt_matricules.Text.Length)
                    matriculesList.Add(txt_matricules.Text.Substring(i, 7));
                else
                    matriculesList.Add(txt_matricules.Text.Substring(i));
            }

            PdfReader reader = null;
             
            try
            {
                reader = new PdfReader(originalPdfFilePath);
                tempPdfFilePath = PathIO.GetTempFileName(); // Utilisez l'alias ici

                using (var tempStream = new FileStream(tempPdfFilePath, FileMode.Create))
                {
                    using (var doc = new Document())
                    {
                        using (var copy = new PdfCopy(doc, tempStream))
                        {
                            doc.Open();

                            for (int pageNum = 1; pageNum <= reader.NumberOfPages; pageNum++)
                            {
                                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                                string text = PdfTextExtractor.GetTextFromPage(reader, pageNum, strategy);

                                // Utilisez une expression régulière pour trouver les matricules
                                MatchCollection matches = Regex.Matches(text, regexPattern);

                                foreach (Match match in matches)
                                {
                                    string matricule = match.Value;
                                    if (matriculesList.Contains(matricule))
                                    {
                                        copy.AddPage(copy.GetImportedPage(reader, pageNum));
                                        matriculesList.Remove(matricule); // Éviter l'ajout multiple
                                    }
                                }
                            }

                            doc.Close();
                        }
                    }
                }

                // Fermez le lecteur de PDF original
                reader.Close();


                // Chargez le nouveau PDF dans axAcroPDF2
                axAcroPDF2.src = tempPdfFilePath;
            }
            catch (Exception ex)
            {
                // Gérez l'exception ici ou affichez un message d'erreur, par exemple :
                Console.WriteLine("Une erreur s'est produite lors de l'extraction du texte du PDF : " + ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_matricules_MouseClick(object sender, MouseEventArgs e)
        {
            txt_matricules.Text = "";
        }
    }
}
