/* THIS PROGRAM DEVELOPED BY FATIH OZDEMIR
 * FOR FILE ORGANIZATON LECTURE
 * COLASCATED HASHING ALGORITHMS COMPARISON
 * GAZI UNIVERSITY 02-12-19
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace file_organization_fth_oz
{
    public partial class file_organization_algorithms : Form
    {
        public int valueCount;
        public int[] array;
        // elle değer girmek istiyorsa aşşağıdaki 2 satırı aç .Ayrıca  üstteki ve button clickdeki ilk iki satırı kapat
        // public int valueCount=9;
        //public int[] array= { 27, 18, 29, 28, 39, 13, 16, 42, 17 };
        public int hashKey;
        public int nonStandartHashKey;
        public int foundedIndex;
        public int generatedNumberRange;


        public file_organization_algorithms()
        {
            InitializeComponent();
            arraySizeValue.Text = "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        // START OF EVERYTHING
        private void generateNumberButton_Click(object sender, EventArgs e)
        {

            valueCount = Int32.Parse(arraySizeValue.Text);
            generatedNumberRange= Int32.Parse(numberRange_textBox.Text);
            generateArray(valueCount);

            SethashKey();
            createTableRows(LISCH_dataGrid);
            createTableRows(LICH_dataGrid);
            createTableRows(EISCH_dataGrid);
            createTableRows(EICH_dataGrid);
            createTableRows(BEISCH_dataGrid);
            createTableRows(RLISCH_dataGrid);

            LISCH();    
            LICH();
            EISCH();
            EICH();
            BEISCH();
            RLISCH();

           setProbsTable();
           setProbsStatistics();

        }
   
        //LISCH tablosonun YERLEŞİMİ----------------------------------------------------------------------
        private void LISCH()
        {
            SethashKey();
            int primaryIndex;

            // tablomuzda yerleştireceğimiz yer boşsa direk yerleştir

            for (int i = 0; i < valueCount; i++) 
            {
                primaryIndex = array[i] % hashKey;

                if (LISCH_dataGrid.Rows[primaryIndex].Cells[1].Value == null)
                {
                    LISCH_dataGrid.Rows[primaryIndex].Cells[1].Value = array[i];
                }


            // Boş değilse
                else
                {
                    int line = hashKey - 1;

                    while (LISCH_dataGrid.Rows[line].Cells[1].Value != null)
                        line--;

                    LISCH_dataGrid.Rows[line].Cells[1].Value = array[i];

                  
                    //where the magic appierce
                    //eğer olması gereken indexli satırın link'i dolu ise o satırın link adresini takip et .Ta ki link satırı dolu olmayan aramaya gelene kadar. 
                    while (LISCH_dataGrid.Rows[primaryIndex].Cells[2].Value != null)
                    {
                        int linkValue = Convert.ToInt32(LISCH_dataGrid.Rows[primaryIndex].Cells[2].Value);
                        primaryIndex=Convert.ToInt32(LISCH_dataGrid.Rows[linkValue].Cells[0].Value);
                    }

                    LISCH_dataGrid.Rows[primaryIndex].Cells[2].Value = line;
                }
            }
            

        }

        //LICH Tablosunun YERLEŞİMİ----------------------------------------------------------------
        private void LICH()
        {
            SethashKey();
            int totalLineCount = hashKey;
            nonStandartHashKey = smallerhashKey(hashKey);
            int primaryIndex;

            // tablomuzda yerleştireceğimiz yer boşsa direk yerleştir

            for (int i = 0; i < valueCount; i++)
            {
                primaryIndex = array[i] % nonStandartHashKey;

                if (LICH_dataGrid.Rows[primaryIndex].Cells[1].Value == null)
                {
                    LICH_dataGrid.Rows[primaryIndex].Cells[1].Value = array[i];
                }


                // Boş değilse
                else
                {
                    int line = totalLineCount - 1;

                    while (LICH_dataGrid.Rows[line].Cells[1].Value != null && line>0)
                        line--;

                    LICH_dataGrid.Rows[line].Cells[1].Value = array[i];


                    //where the magic appierce
                    //eğer olması gereken indexli satırın link'i dolu ise o satırın link adresini takip et .Ta ki link satırı dolu olmayan aramaya gelene kadar. 
                    while (LICH_dataGrid.Rows[primaryIndex].Cells[2].Value != null)
                    {
                        int linkValue = Convert.ToInt32(LICH_dataGrid.Rows[primaryIndex].Cells[2].Value);
                        primaryIndex = Convert.ToInt32(LICH_dataGrid.Rows[linkValue].Cells[0].Value);
                    }

                    LICH_dataGrid.Rows[primaryIndex].Cells[2].Value = line;
                }
            }

            LICH_textBox.Text = "Overflow Area Starts From : " + nonStandartHashKey;
        }



        //EISCH tablosonun YERLEŞİMİ----------------------------------------------------------------------
        private void EISCH()
        {
            SethashKey();
            int primaryIndex;

            // tablomuzda yerleştireceğimiz yer boşsa direk yerleştir

            for (int i = 0; i < valueCount; i++)
            {
                primaryIndex = array[i] % hashKey;

                if (EISCH_dataGrid.Rows[primaryIndex].Cells[1].Value == null)
                {
                    EISCH_dataGrid.Rows[primaryIndex].Cells[1].Value = array[i];
                }


                // Boş değilse
                else
                {
                    int line = hashKey - 1;

                    while (EISCH_dataGrid.Rows[line].Cells[1].Value != null)
                        line--;

                    EISCH_dataGrid.Rows[line].Cells[1].Value = array[i];   
                 
                   //değeri yerleştirdiğimiz satırın link i asıl yerinin gösterdiği yeri gösterecek
                    EISCH_dataGrid.Rows[line].Cells[2].Value = EISCH_dataGrid.Rows[primaryIndex].Cells[2].Value;
                    EISCH_dataGrid.Rows[primaryIndex].Cells[2].Value = EISCH_dataGrid.Rows[line].Cells[0].Value;

                }
            }


        }


        //EICH Tablosunun YERLEŞİMİ----------------------------------------------------------------
        private void EICH()
        {
            SethashKey();
            int totalLineCount = hashKey;
            nonStandartHashKey = smallerhashKey(hashKey);
            int primaryIndex;

            // tablomuzda yerleştireceğimiz yer boşsa direk yerleştir

            for (int i = 0; i < valueCount; i++)
            {
                primaryIndex = array[i] % nonStandartHashKey;

                if (EICH_dataGrid.Rows[primaryIndex].Cells[1].Value == null)
                {
                    EICH_dataGrid.Rows[primaryIndex].Cells[1].Value = array[i];
                }


                // Boş değilse
                else
                {
                    int line = totalLineCount - 1;

                    while (EICH_dataGrid.Rows[line].Cells[1].Value != null && line > 0)
                        line--;

                    EICH_dataGrid.Rows[line].Cells[1].Value = array[i];


                    //where the magic appierce
                    //değeri yerleştirdiğimiz satırın link i asıl yerinin gösterdiği yeri gösterecek
                    EICH_dataGrid.Rows[line].Cells[2].Value = EICH_dataGrid.Rows[primaryIndex].Cells[2].Value;
                    EICH_dataGrid.Rows[primaryIndex].Cells[2].Value = EICH_dataGrid.Rows[line].Cells[0].Value;

                }
            }

            EICH_textBox.Text = "Overflow Area Starts From : " + nonStandartHashKey ;
        }
        //BEISCH Tablosunun YERLŞEİMİ------------------------------------------------------------------
        private void BEISCH()
        {
            SethashKey();
            bool flag = true; // bayrak havada ise baştan , değil ise sondan ekler.
            int primaryIndex;

            // tablomuzda yerleştireceğimiz yer boşsa direk yerleştir

            for (int i = 0; i < valueCount; i++)
            {
                primaryIndex = array[i] % hashKey;
                if (BEISCH_dataGrid.Rows[primaryIndex].Cells[1].Value == null)
                {
                    BEISCH_dataGrid.Rows[primaryIndex].Cells[1].Value = array[i];
                }
                else if (flag)
                {
                    int line = 0;
                    while (BEISCH_dataGrid.Rows[line].Cells[1].Value != null)
                        line++;

                    BEISCH_dataGrid.Rows[line].Cells[1].Value = array[i];

                    //değeri yerleştirdiğimiz satırın link i asıl yerinin gösterdiği yeri gösterecek
                    BEISCH_dataGrid.Rows[line].Cells[2].Value = BEISCH_dataGrid.Rows[primaryIndex].Cells[2].Value;
                    BEISCH_dataGrid.Rows[primaryIndex].Cells[2].Value = BEISCH_dataGrid.Rows[line].Cells[0].Value;
                    flag = false;
                }
                else
                {

                        int line = hashKey - 1;

                        while (BEISCH_dataGrid.Rows[line].Cells[1].Value != null)
                            line--;

                        BEISCH_dataGrid.Rows[line].Cells[1].Value = array[i];

                        //değeri yerleştirdiğimiz satırın link i asıl yerinin gösterdiği yeri gösterecek
                        BEISCH_dataGrid.Rows[line].Cells[2].Value = BEISCH_dataGrid.Rows[primaryIndex].Cells[2].Value;
                        BEISCH_dataGrid.Rows[primaryIndex].Cells[2].Value = BEISCH_dataGrid.Rows[line].Cells[0].Value;
                   
                    flag = true;
                    
                }
            }

        }

        //RLISCH tablosonun YERLEŞİMİ----------------------------------------------------------------------
        private void RLISCH()
        {
            Random rastgele = new Random();
            int randomIndex;
            SethashKey();
            int primaryIndex;


            // tablomuzda yerleştireceğimiz yer boşsa direk yerleştir

            for (int i = 0; i < valueCount; i++)
            {
                primaryIndex = array[i] % hashKey;

                if (RLISCH_dataGrid.Rows[primaryIndex].Cells[1].Value == null)
                {
                    RLISCH_dataGrid.Rows[primaryIndex].Cells[1].Value = array[i];
                }


                // Boş değilse
                else
                {
                    int line = rastgele.Next(0, hashKey);

                    while (RLISCH_dataGrid.Rows[line].Cells[1].Value != null)
                        line= rastgele.Next(0, hashKey);

                    RLISCH_dataGrid.Rows[line].Cells[1].Value = array[i];


                    //where the magic appierce
                    //eğer olması gereken indexli satırın link'i dolu ise o satırın link adresini takip et .Ta ki link satırı dolu olmayan aramaya gelene kadar. 
                    while (RLISCH_dataGrid.Rows[primaryIndex].Cells[2].Value != null)
                    {
                        int linkValue = Convert.ToInt32(RLISCH_dataGrid.Rows[primaryIndex].Cells[2].Value);
                        primaryIndex = Convert.ToInt32(RLISCH_dataGrid.Rows[linkValue].Cells[0].Value);
                    }

                    RLISCH_dataGrid.Rows[primaryIndex].Cells[2].Value = line;
                }
            }


        }
        //======================================================================================================

        //Prob Comperison Tablosunun Yerleştirilmesi
        private void setProbsTable()
        {
            probCom_dataGrid.RowCount = valueCount;

            for (int i = 0 ; i < valueCount; i++) 
            {
               probCom_dataGrid.Rows[i].Cells[0].Value= array[i];
               probCom_dataGrid.Rows[i].Cells[1].Value = probCounts_Standart(LISCH_dataGrid,array[i]);
               probCom_dataGrid.Rows[i].Cells[2].Value = probCounts_UNStandart(LICH_dataGrid,array[i]);
               probCom_dataGrid.Rows[i].Cells[3].Value = probCounts_Standart(EISCH_dataGrid,array[i]);
               probCom_dataGrid.Rows[i].Cells[4].Value = probCounts_UNStandart(EICH_dataGrid,array[i]);
               probCom_dataGrid.Rows[i].Cells[5].Value = probCounts_Standart(BEISCH_dataGrid,array[i]);
               probCom_dataGrid.Rows[i].Cells[6].Value = probCounts_Standart(RLISCH_dataGrid,array[i]);
            }
        }

        //Verilen Tabloda bi değerin Prob Yerleştirilmesi-----------------------------
        private int probCounts_Standart(DataGridView table,int i)
        {
            int probCounter = 1;
            int lookingIndex = i % hashKey;

            while (Convert.ToInt32(table.Rows[lookingIndex].Cells[1].Value) != i)
            {
                lookingIndex = Convert.ToInt32(table.Rows[lookingIndex].Cells[2].Value);
                probCounter++;  
                if (probCounter > valueCount)
                 return -1;
           
            }
         
                return probCounter;
           
        }
        //Standart Olmayan Algoritmalarda HashKey Farklı olduğundan extra bir fonksiyon yazma ihtiyacı hissettim-----------------------------
        private int probCounts_UNStandart(DataGridView table, int i)
        {
            int probCounter = 1;
            int lookingIndex = i % nonStandartHashKey;

            while (Convert.ToInt32(table.Rows[lookingIndex].Cells[1].Value) != i)
            {
                lookingIndex = Convert.ToInt32(table.Rows[lookingIndex].Cells[2].Value);
                probCounter++;
                if (probCounter > valueCount)
                    return -1;
            }
           

                return probCounter;


        }

        //ProbCom' da verilen columdaki toplam prob sayısı
        public int TotalProbCount(int column)
        {
            int sum=0;

            for (int i = 0; i < valueCount; i++)
                sum += Convert.ToInt32(probCom_dataGrid.Rows[i].Cells[column].Value);

            return sum;
        }
        //ProbCom' da verilen columdaki toplam prob sayısı
        public float avarageProb(int column)
        {
            return (float)TotalProbCount(column) / valueCount;
        }

        //Total istatistics Alanının doldurulması
        public void setProbsStatistics()
        {
            ProbsStatistics_textBox.Text = "LISCH -> totalProb= " + TotalProbCount(1) + "    avarageProb = " + avarageProb(1) + Environment.NewLine
                + "LICH -> totalProb= " + TotalProbCount(2) + "    avarageProb = " + avarageProb(2) + Environment.NewLine
                + "EISCH -> totalProb= " + TotalProbCount(3) + "    avarageProb = " + avarageProb(3) + Environment.NewLine
                + "EICH -> totalProb= " + TotalProbCount(4) + "    avarageProb = " + avarageProb(4) + Environment.NewLine
                + "BEISCH -> totalProb= " + TotalProbCount(5) + "    avarageProb = " + avarageProb(5) + Environment.NewLine
                + "RLISCH -> totalProb= " + TotalProbCount(6) + "    avarageProb = " + avarageProb(6)
                + Environment.NewLine+ Environment.NewLine+ Environment.NewLine 
                + "PACKING FACTOR IS " +Math.Round(((double)valueCount/hashKey)*100) + "%";


        }

        void createTableRows(DataGridView table)
        {
            table.RowCount = hashKey;

            for (int i= 0;i<hashKey;i++)
            {
                table.Rows[i].Cells[0].Value = i;
                table.Rows[i].Cells[1].Value = null;
                table.Rows[i].Cells[2].Value = null;
            }
        }

        //Packing factörün %90 çıkması için gereken hashing fonksiyonunun asal sayısını bulma
        private void SethashKey()
        {
            int number = (valueCount + valueCount /11 )+1;

            while (!isPrimeNumber(number))
            {
                number++;
            }

            hashKey = number;

        }

        //Check the number is it a prime number or not
        public static bool isPrimeNumber (int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        //OWERFLOW area kullanan fonksiyonlar için bi küçük Hash Asal sayısını bulma. Adress faktörü %85 oranında tutmaya çalışıyoruz.
        public int smallerhashKey(int number)
        {
            number-= Convert.ToInt32((double)number*0.20); // adress faktörün  yalaşık %85 çıkması için gerekli hesaplama
            while (!isPrimeNumber(number))
                number--;     
            return number;
        }


        // find packing factor
        private double PackingFactor()
        {
            return (double)valueCount / (double)hashKey;
        }

        // generating new array 1-900 &
        // 0. index value, 1. index is adress pointer
        private void generateArray(int valueCount)
        {
            Random rastgele = new Random();
            int value;
            array = new int[valueCount];

            for (int i = 0; i < valueCount; i++)
            {
                value = rastgele.Next(0, generatedNumberRange);
                array[i] = value;
            }

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(searchValue_textBox.Text);
            if (probCounts_Standart(LISCH_dataGrid, deger) == -1)
                searchResults_textBox.Text = "Upss. This value is not a generated one";
            else
            {
                searchResults_textBox.Text = "FOUNDED" + Environment.NewLine
                    + "LISCH  Table index  => " + probSearch_Standart(LISCH_dataGrid, deger) + Environment.NewLine
                    + "LICH    Table index  => " + probSearch_UNStandart(LICH_dataGrid, deger) + Environment.NewLine
                    + "EISCH  Table index  => " + probSearch_Standart(EISCH_dataGrid, deger) + Environment.NewLine
                    + "EICH    Table index  => " + probSearch_UNStandart(EICH_dataGrid, deger) + Environment.NewLine
                    + "BEISCH Table index  => " + probSearch_Standart(BEISCH_dataGrid, deger) + Environment.NewLine
                    + "RLISCH Table index  => " + probSearch_Standart(RLISCH_dataGrid, deger);
            }

        }
        private int probSearch_Standart(DataGridView table, int i)
        {
            int lookingIndex = i % hashKey;

            while (Convert.ToInt32(table.Rows[lookingIndex].Cells[1].Value) != i)
            {
                lookingIndex = Convert.ToInt32(table.Rows[lookingIndex].Cells[2].Value);
            }
            return lookingIndex;
        }
        
        private int probSearch_UNStandart(DataGridView table, int i)
        {
          
            int lookingIndex = i % nonStandartHashKey;

            while (Convert.ToInt32(table.Rows[lookingIndex].Cells[1].Value) != i)
            {
                lookingIndex = Convert.ToInt32(table.Rows[lookingIndex].Cells[2].Value);
             
            }
            return lookingIndex;


        }

     
    }
}
