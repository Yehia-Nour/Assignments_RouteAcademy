using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day02G03.Encapsulation
{
    internal struct PhoneNoteBook
    {
        private string[]? names;
        private int[]? numbers;
        private int size;

        // Reaad Only Property
        public int Size
        {
            get
            {
                return size;
            }
        }

        public int this[string name]
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (name == names[i])
                        {
                            return numbers[i];
                        }
                    }
                }
                return -1;
            }
            set
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (name == names[i])
                        {
                            numbers[i] = value;
                            break;
                        }
                    }
                }
            }
        }

        public string this[int index]
        {
            get
            {
                if(names is not null && numbers is not null && index < size && index >= 0)
                {
                    return $"Index: {index}, Name: {names[index]}, Number: {numbers[index]}";
                }
                return "No Name";
            }
        }

        public PhoneNoteBook(int NoteBookSize)
        {
            size = NoteBookSize;
            names = new string[size];
            numbers = new int[size];
        }

        public void Add(int index, string name, int number)
        {
            if(names is not null && numbers is not null && index < size && index >= 0)
            {
                names[index] = name;
                numbers[index] = number;
            }
        }

        public void SetNumber(string name, int newNumber)
        {
            if(names is not null && numbers is not null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (name == names[i])
                    {
                        numbers[i] = newNumber;
                        break;
                    }
                }
            }
        }

        public int GetNumber(string name)
        {
            if( names is not null && numbers is not null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (name == names[i])
                    {
                        return numbers[i];
                    }
                }
            }
            return -1;
        }
    }
}
