using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADFGVX
{
    public class DumbSolution
    {
        public char character;
        public int numOf;
    }
    public class Cell
    {
        public int x;
        public int y;
        public char letter;
        public char KeyLetter { get; set; }
        public char RowLetterV
        {
            get
            {
                switch (x)
                {
                    case (0):
                        return 'A';
                    case (1):
                        return 'D';
                    case (2):
                        return 'F';
                    case (3):
                        return 'G';
                    case (4):
                        return 'V';
                    case (5):
                        return 'X';
                    default:
                        return 'O';
                }
            }
        }
        public char ColumnLetterV
        {
            get
            {
                switch (y)
                {
                    case (0):
                        return 'A';
                    case (1):
                        return 'D';
                    case (2):
                        return 'F';
                    case (3):
                        return 'G';
                    case (4):
                        return 'V';
                    case (5):
                        return 'X';
                    default:
                        return 'O';
                }
            }
        }

        public char RowLetter
        {
            get
            {
                switch (x)
                {
                    case (0):
                        return 'A';
                    case (1):
                        return 'D';
                    case (2):
                        return 'F';
                    case (3):
                        return 'G';
                    case (4):
                        return 'X';
                    default:
                        return 'O';
                }
            }
        }
        public char ColumnLetter
        {
            get
            {
                switch (y)
                {
                    case (0):
                        return 'A';
                    case (1):
                        return 'D';
                    case (2):
                        return 'F';
                    case (3):
                        return 'G';
                    case (4):
                        return 'X';
                    default:
                        return 'O';
                }
            }
        }
        public Cell(int x, int y, char letter)
        {
            this.x = x;
            this.y = y;
            this.letter = letter;
        }
        public static List<Cell> CreateMatrice(string alphabet)
        {
            var matrice = new List<Cell>();
            int matriceDimension = alphabet.Length % 5 == 0 ? 5 : 6;
            int i = 0;
            for (int x = 0; x < matriceDimension; x++)
            {
                if (x > 0) i += matriceDimension;
                for (int y = 0; y < matriceDimension; y++)
                {
                    var cell = new Cell(x, y, alphabet[i + y]);
                    matrice.Add(cell);
                }
            }
            return matrice;
        }

        public static List<Cell> EncryptionMatrice(string key, string fractionatedMessage)
        {
            int x = key.Length;

            var matrice = new List<Cell>();

            int k = 0;
            for (int i = 0; i < fractionatedMessage.Length; i++)
            {
                if (k == x) k = 0;
                var cell = new Cell(0, 0, fractionatedMessage[i]);
                cell.KeyLetter = key[k];
                matrice.Add(cell);
                k++;
            }

            return matrice;
        }

        public static List<Cell> DecryptionMatrice(string key, string encryptedMessage)
        {
            var matrice = new List<Cell>();
            if (key != null && encryptedMessage != null)
            {
                string keyAlphabetically = String.Concat(key.OrderBy(c => c));


                int k = 0;
                for (int i = 0; i < encryptedMessage.Length; i++)
                {
                    if (encryptedMessage[i] == ' ')
                    {
                        k++;
                        continue;
                    }
                    var cell = new Cell(0, 0, encryptedMessage[i]);
                    cell.KeyLetter = keyAlphabetically[k];
                    matrice.Add(cell);
                }
            }

            return matrice;
        }

    }

}
