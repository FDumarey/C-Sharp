using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Printing
{
    public partial class frmPrinting : Form
    {
        int pageNumber;
        PrintDocument myDocument;
        Image myImage;
        const int numberCountries = 62;
        const int countriesPerPage = 25;
        string[] country = new string[numberCountries];
        string[] capital = new string[numberCountries];
        bool lastPage;

        public frmPrinting()
        {
            InitializeComponent();
        }

        private void frmPrinting_Load(object sender, EventArgs e)
        {
            country[0] = "Afghanistan"; capital[0] = "Kabul";
            country[1] = "Albania"; capital[1] = "Tirane";
            country[2] = "Australia"; capital[2] = "Canberra";
            country[3] = "Austria"; capital[3] = "Vienna";
            country[4] = "Bangladesh";capital[4] = "Dacca";
            country[5] = "Barbados"; capital[5] = "Bridgetown";
            country[6] = "Belgium"; capital[6] = "Brussels";
            country[7] = "Bulgaria"; capital[7] = "Sofia";
            country[8] = "Burma"; capital[8] = "Rangoon";
            country[9] = "Cambodia"; capital[9] = "Phnom Penh";
            country[10] = "China"; capital[10] = "Peking";
            country[11] = "Czechoslovakia"; capital[11] = "Prague";
            country[12] = "Denmark"; capital[12] = "Copenhagen";
            country[13] = "Egypt"; capital[13] = "Cairo";
            country[14] = "Finland"; capital[14] = "Helsinki";
            country[15] = "France"; capital[15] = "Paris";
            country[16] = "Germany"; capital[16] = " Berlin";
            country[17] = "Greece"; capital[17] = "Athens";
            country[18] = "Hungary"; capital[18] = "Budapest";
            country[19] = "Iceland"; capital[19] = "Reykjavik";
            country[20] = "India"; capital[20] = "New Delhi";
            country[21] = "Indonesia"; capital[21] = "Jakarta";
            country[22] = "Iran"; capital[22] = "Tehran";
            country[23] = "Iraq"; capital[23] = "Baghdad";
            country[24] = "Ireland"; capital[24] = "Dublin";
            country[25] = "Israel"; capital[25] = "Jerusalem";
            country[26] = "Italy"; capital[26] = "Rome";
            country[27] = "Japan"; capital[27] = "Tokyo";
            country[28] = "Jordan"; capital[28] = "Amman";
            country[29] = "Kuwait"; capital[29] = "Kuwait";
            country[30] = "Laos"; capital[30] = "Vientiane";
            country[31] = "Lebanon"; capital[31] = "Beirut";
            country[32] = "Luxembourg"; capital[32] = "Luxembourg";
            country[33] = "Malaysia"; capital[33] = "Kuala Lumpur";
            country[34] = "Mongolia"; capital[34] = "Ulaanbaatar";
            country[35] = "Nepal"; capital[35] = "Katmandu";
            country[36] = "Netherlands"; capital[36] = "Amsterdam";
            country[37] = "New Zealand"; capital[37] = "Wellington";
            country[38] = "North Korea"; capital[38] = "Pyongyang";
            country[39] = "Norway"; capital[39] = "Oslo";
            country[40] = "Oman"; capital[40] = "Muscat";
            country[41] = "Pakistan"; capital[41] = "Islamabad";
            country[42] = "Philippines"; capital[42] = "Manila";
            country[43] = "Poland"; capital[43] = "Warsaw";
            country[44] = "Portugal"; capital[44] = "Lisbon";
            country[45] = "Romania"; capital[45] = "Bucharest";
            country[46] = "Russia"; capital[46] = "Moscow";
            country[47] = "Saudi Arabia"; capital[47] = "Riyadh";
            country[48] = "Singapore"; capital[48] = "Singapore";
            country[49] = "South Korea"; capital[49] = "Seoul";
            country[50] = "Spain"; capital[50] = "Madrid";
            country[51] = "Sri Lanka"; capital[51] = "Colombo";
            country[52] = "Sweden"; capital[52] = "Stockholm";
            country[53] = "Switzerland"; capital[53] = "Bern";
            country[54] = "Syria"; capital[54] = "Damascus";
            country[55] = "Taiwan"; capital[55] = "Taipei";
            country[56] = "Thailand"; capital[56] = "Bangkok";
            country[57] = "Turkey"; capital[57] = "Ankara";
            country[58] = "United Kingdom"; capital[58] = "London";
            country[59] = "Vietnam"; capital[59] = "Hanoi";
            country[60] = "Yemen"; capital[60] = "Sana";
            country[61] = "Yugoslavia"; capital[61] = "Belgrade";

            myImage = Image.FromFile(Application.StartupPath + "\\world.wmf");
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            lastPage = false;

            myDocument = new PrintDocument();
            myDocument.DocumentName = "World Capitals";
            myDocument.PrintPage += new PrintPageEventHandler(this.PrintPage);

            dlgPreview.Document = myDocument;
            dlgPreview.ShowDialog();
            myDocument.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            lastPage = false;

            myDocument = new PrintDocument();
            myDocument.DocumentName = "World Capitals";
            myDocument.PrintPage += new PrintPageEventHandler(this.PrintPage);

            dlgPrint.Document = myDocument;
            if (dlgPrint.ShowDialog() == DialogResult.OK)
            {
                myDocument.Print();
            }
            myDocument.Dispose();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Font printFont;
            SizeF sSize;
            int y, i, iEnd;
            float ratio;

            if (!lastPage)
            {
                printFont = new Font("Arial", 20, FontStyle.Bold);
                sSize = e.Graphics.MeasureString("Countries and Capitals - Page " + pageNumber.ToString(), printFont);
                e.Graphics.DrawString("Countries and Capitals - Page "+pageNumber.ToString(),printFont,Brushes.Black,e.MarginBounds.Left+(int)(0.5*(e.MarginBounds.Width-sSize.Width)),e.MarginBounds.Top);

                printFont = new Font("Arial", 14, FontStyle.Underline);
                y = (int)(e.MarginBounds.Top + 4 * printFont.GetHeight());
                e.Graphics.DrawString("Country", printFont, Brushes.Black, e.MarginBounds.X, y);
                e.Graphics.DrawString("Capital", printFont, Brushes.Black, (int)(e.MarginBounds.X + 0.5 * e.MarginBounds.Width), y);
                y += (int)(2 * printFont.GetHeight());
                
                printFont = new Font("Arial", 14, FontStyle.Regular);
                iEnd = countriesPerPage * pageNumber;
                if (iEnd > numberCountries)
                {
                    iEnd = numberCountries;
                    lastPage = true;
                }

                for (i=countriesPerPage*(pageNumber-1);i<iEnd;i++)
                {
                    e.Graphics.DrawString(country[i], printFont, Brushes.Black, e.MarginBounds.X, y);
                    e.Graphics.DrawString(capital[i], printFont, Brushes.Black, (int)(e.MarginBounds.X + 0.5 * e.MarginBounds.Width), y);
                    y += (int)(printFont.GetHeight());
                }
                pageNumber++;
                e.HasMorePages = true;
            }
            else
            {
                ratio = ((float)myImage.Width / myImage.Height);
                e.Graphics.DrawImage(myImage, e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, (int)(e.MarginBounds.Height / ratio));
                e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, (int)(e.MarginBounds.Height / ratio));
                e.HasMorePages = false;
                pageNumber = 1;
                lastPage = false;
            }
        }
    }
}
