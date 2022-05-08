using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace OFB.Data.Araclar
{
    public class PDFConvert
    {

        public static void ExportDtTableToPDF(DataTable dtblTable, string pdfPath, string Header)
        {


            FileStream fs = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document documunet = new Document();
            documunet.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter wtriter = PdfWriter.GetInstance(documunet, fs);
            documunet.Open();

            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 16, 1, BaseColor.DARK_GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(Header.ToUpper(), fntHead));
            documunet.Add(prgHeading);



            //Header ile Table Atası Cizgi
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            documunet.Add(p);

            documunet.Add(new Chunk("\n", fntHead));

            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            table.WidthPercentage = 100;
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, new BaseColor(1,190,255));
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor =new BaseColor(34,36,49);
                cell.BorderColor = new BaseColor(255, 255, 255,50);
                cell.BorderColorTop = new BaseColor(238,238,238);
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                cell.Padding = 2;
                table.AddCell(cell);
            }


            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                    
                }
            }


            documunet.Add(table);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2, BaseColor.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Create by : " + Kullanici.KullaniciInfo.K_AD.ToUpper() + " " + Kullanici.KullaniciInfo.K_SOYAD.ToUpper(), fntAuthor));
            documunet.Add(prgAuthor);

            documunet.Close();
            fs.Close();



        }

        private static BaseColor SolidColorBrush(object p)
        {
            throw new NotImplementedException();
        }
    }
}
