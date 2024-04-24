﻿using System.Drawing;
using System.IO;

namespace L2_archer
{
    //Vytvořte třídu Lucistnik, ktera bude mit vlastnost PocetSipu a metodu Vystrel. PocetSipu muze byt nastaven treba na 10.
    //Pokud bude mit dost sipu, napise metoda Vystrel na konzoli text: Vzdy se strefim primo do prostred!
    //Metoda Vystrel uvnitr s kazdym vystrelem snizi pocet sipu.
    //Pokud bude pocet 0, metoda Vystrel vypise "Nemam sipy".
    //Napiste program, ktery vytvori lucistnika a vystreli vsechny sipy.

    internal class Program
    {
        static void Main(string[] args)
        {
           Archer archer = new Archer(5);

            do
            {
                archer.shotArrow();
            }
            while (archer.AmountOfArrows >= 0);
        }
    }
}
