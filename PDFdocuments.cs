using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Licence.Properties;

namespace Licence
{
    class PDFdocuments
    {

        public static string CreatePDF(string Titre_Document, string point_controle, string texte_regl, string date_controle, string date_envois, string constats, string recommendations, string score, string impact, string structure)
        {
            

            string namefile = writeInPdf(Titre_Document, point_controle, texte_regl, date_controle, date_envois, constats, recommendations, score, impact, structure);
            return namefile;

        }
        private static iTextSharp.text.Image write_image()
        {
            //iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(Path.GetFullPath(Properties.Resources.Resource("image01")));
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(Path.GetFullPath("C:\\Users\\mac pro\\source\\repos\\Licence\\Resources\\logoar.png"));
            iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(image);

            if (pic.Height > pic.Width)
            {
                //Maximum height is 800 pixels.
                float percentage = 0.0f;
                percentage = 60 / pic.Height;
                pic.ScalePercent(percentage * 100);
            }
            else
            {
                //Maximum width is 600 pixels.
                float percentage = 0.0f;
                percentage = 60 / pic.Width;
                pic.ScalePercent(percentage * 100);
            }

            pic.Border = iTextSharp.text.Rectangle.BOX;
        
            pic.BorderWidth = 0;
            pic.Alignment = Element.ALIGN_RIGHT;

            return pic;



        }

        public static void OpenPdf(string filePath)
        {
            if (!string.IsNullOrWhiteSpace(filePath))
            {
                Impression imp = new Impression(@filePath);
                imp.Show();
            }
        }

        
        private static string writeInPdf( string Titre_Document, string nom_pnt, string texte_reg, string datecontrole, string date_envois, string constats, string Recommandations,string Score_risques, string Impact, string structure)
        {
            //Exporting to PDF
            string folderPath = "C:\\f09851c3524Uhtfg632AG\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            DateTime dt = DateTime.Now;

            string namefile = (Titre_Document.Replace('/', '_')).Replace(':', '_') + (dt.ToString().Replace('/', '_')).Replace(':', '_') + ".pdf";
            using (FileStream stream = new FileStream(folderPath + namefile, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 20f, 20f, 20f, 20f);


                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(write_image());
                /******************************************************/



                // create table for head :
                PdfPTable pdfhead = new PdfPTable(3);
                pdfhead.DefaultCell.Padding = 3;
                pdfhead.WidthPercentage = 100;
                pdfhead.DefaultCell.BorderWidth = 0;
                pdfhead.HorizontalAlignment = Element.ALIGN_LEFT;
                


                string adress = "Hydra, le " + date_envois+"\n\n";


                Paragraph adressDocument = new Paragraph(adress);
                adressDocument.Alignment = Element.ALIGN_LEFT;
                adressDocument.Font.SetFamily("Times New Roman");


                PdfPCell cl1 = new PdfPCell();
                PdfPCell cl2 = new PdfPCell();
                PdfPCell cl3 = new PdfPCell(adressDocument);

                cl1.HasBorder(iTextSharp.text.Rectangle.NO_BORDER); // <= this did nothing
                cl1.BorderWidth = 0;

                cl2.HasBorder(iTextSharp.text.Rectangle.NO_BORDER); // <= this did nothing
                cl2.BorderWidth = 0;

                cl3.HasBorder(iTextSharp.text.Rectangle.NO_BORDER); // <= this did nothing
                cl3.BorderWidth = 0;
                cl3.HorizontalAlignment = Element.ALIGN_RIGHT;


                pdfhead.AddCell(cl1);
                pdfhead.AddCell(cl2);
                pdfhead.AddCell(cl3);
                pdfDoc.Add(pdfhead);



                string ref_ = "Référence: N° .. / Année - DCC\n";
                Phrase r = new Phrase(ref_);
                r.Font.SetStyle(iTextSharp.text.Font.BOLD);

                Phrase direc = new Phrase("De:");
                direc.Font.SetStyle(iTextSharp.text.Font.BOLD);


                string direc1="Direction Conformité &Gouvernance\n";

                Phrase des = new Phrase("A: "); string des1=structure+"\n";
                des.Font.SetStyle(iTextSharp.text.Font.BOLD);



                string ob = "OBJET DU RAPPORT: ";
                Phrase objt = new Phrase(ob);
                objt.Font.SetStyle(iTextSharp.text.Font.BOLD);
                objt.Font.SetStyle(iTextSharp.text.Font.UNDEFINED);
                string obj1=" Contrôle de la conformité du «" + nom_pnt + " »\n";

                
                pdfDoc.Add(r);
                pdfDoc.Add(direc); pdfDoc.Add(new Phrase(direc1));
                pdfDoc.Add(des); pdfDoc.Add(new Phrase(des1));
                pdfDoc.Add(objt); pdfDoc.Add(new Phrase(obj1));




                pdfDoc.Add(new Chunk("\n"));
                /******************************************************/

                PdfPTable head = new PdfPTable(1);
                head.DefaultCell.PaddingTop = 25;
                head.DefaultCell.PaddingBottom= 25;
                head.DefaultCell.PaddingLeft = 100;
                head.DefaultCell.PaddingRight = 100;
                head.WidthPercentage = 100;
                head.DefaultCell.BorderWidthTop = 1;
                head.DefaultCell.BorderWidthBottom = 1;
                head.DefaultCell.BorderWidthLeft = 0;
                head.DefaultCell.BorderWidthRight = 0;
                head.HorizontalAlignment = Element.ALIGN_CENTER;


                string Grand_titre = "RAPPORT DE CONTROLE DE LA CONFORMITE";


                Paragraph p1 = new Paragraph(Grand_titre + "\n\n\n"+ "     «" + nom_pnt + " »\n\n\n");
                
                p1.Alignment = Element.ALIGN_CENTER;
                p1.Font.SetStyle(iTextSharp.text.Font.BOLD);


                // head.AddCell("\n" ); 
                head.AddCell(p1);
                head.CompleteRow();
                
                //head.AddCell("\n");
                pdfDoc.Add(head);





                /****************************************************/
                string titre1 = "PREAMBULE \r\n\r\n";
                Phrase ptitre1 = new Phrase(titre1);
                ptitre1.Font.SetStyle(iTextSharp.text.Font.BOLD);

                string texte1 = "Dans le cadre de la Conformité Réglementaire mise en place par la structure de la Conformité & Gouvernance, des contrôles périodiques sont initiés sur certains points sensibles à l’effet de s’assurer du respect des dispositions législatives et règlementaires et aux normes déontologiques et des codes de conduites internes.\r\n\r\nLes types de contrôles sont effectués soit à distance, soit des « Self Compliance » effectués par la structure contrôlée.\r\n\r\n";
                
                string titre2 = "TEXTES DE REFERENCES  \r\n";
                Phrase ptitre2 = new Phrase(titre2);
                ptitre2.Font.SetStyle(iTextSharp.text.Font.BOLD);

                string texte2 = texte_reg+ "\r\n\r\n";
               
                string titre3 = "PERIODICITE DE L’ANALYSE :   \r\n";
                Phrase ptitre3 = new Phrase(titre3);
                ptitre3.Font.SetStyle(iTextSharp.text.Font.BOLD);

                string texte3 = "Période d’analyse ciblée : Date de contrôle: "+datecontrole+" –date d’envoi : "+date_envois+ " \r\n\r\n";

                string titre4 = "CONSTATS :\r\n\r\n";
                Phrase ptitre4 = new Phrase(titre4);
                ptitre4.Font.SetStyle(iTextSharp.text.Font.BOLD);

                string texte4 =constats+ "\r\n";

                string titre5 = "Recommandations :";
                Phrase ptitre5 = new Phrase(titre5);
                ptitre5.Font.SetStyle(iTextSharp.text.Font.BOLD);

                string texte5 = Recommandations+ "\r\n";

                string titre6 = "Score du risques : ";
                Phrase ptitre6 = new Phrase(titre6);
                ptitre6.Font.SetStyle(iTextSharp.text.Font.BOLD);
                
                string texte6 = Score_risques + "\r\n";

                string titre7 = "Impact : ";
                Phrase ptitre7 = new Phrase(titre7);
                ptitre7.Font.SetStyle(iTextSharp.text.Font.BOLD);

                string texte7 = Impact + "\r\n";




                string texte8 = "Demeurons à votre entière disposition pour tout éclaircissement et/ou complément d’informations requis.\r\n \r\n";

                string texte9 = "Cordialement. ";



                pdfDoc.Add(ptitre1);
                pdfDoc.Add(new Phrase(texte1));

                pdfDoc.Add(ptitre2);
                pdfDoc.Add(new Phrase(texte2));

                pdfDoc.Add(ptitre3);
                pdfDoc.Add(new Phrase(texte3));

                pdfDoc.Add(ptitre4);
                pdfDoc.Add(new Phrase(texte4));

                pdfDoc.Add(ptitre5);
                pdfDoc.Add(new Phrase(texte5));

                pdfDoc.Add(ptitre6);
                pdfDoc.Add(new Phrase(texte6));

                pdfDoc.Add(ptitre7);
                pdfDoc.Add(new Phrase(texte7));

                pdfDoc.Add(new Phrase(texte8));
                pdfDoc.Add(new Phrase(texte9));




                pdfDoc.Add(new Phrase("\n"));
                //pdfDoc.Add(new Phrase("\n"));

                PdfPTable pdfta1 = new PdfPTable(3);
                pdfta1.DefaultCell.Padding = 3;
                pdfta1.WidthPercentage = 100;
                pdfta1.DefaultCell.BorderWidth = 0;
                pdfta1.HorizontalAlignment = Element.ALIGN_CENTER;


                
                

                pdfta1.CompleteRow();

                pdfta1.AddCell(new Phrase("\n"));
                pdfta1.AddCell(new Phrase("\n"));
                

                pdfta1.CompleteRow();



                pdfDoc.Add(pdfta1);
                pdfDoc.Close();
                stream.Close();
            }
            return folderPath + namefile;
        }


        public static void CreateReproting(string Titre_Document, string point_controle, string texte_regl, string date_controle, string date_envois, string constats, string recommendations, string score, string impact, string structure)

        {
            string namefile1 = CreatePDF(Titre_Document, point_controle, texte_regl, date_controle, date_envois, constats, recommendations, score, impact, structure);
            OpenPdf(namefile1);

        }
    }
}