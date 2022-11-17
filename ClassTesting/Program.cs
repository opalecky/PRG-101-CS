// Class [Třída] - Definice struktury

/*
 * ENUM - Vyčíslení = Přiřazení hodnoty ke jménu v tabulce paměti
 * 
 * 3 základní koncepty OOP (objektově orientované programování):
 * Abstrakce (Enkapsulace) - Třída je jenom černá schránka, která si dělá svoje (Abstrakce), 
 *                           Enkapsulace (viditelnost)
 *                            - Private = Vidí jenom ta jediná třída (nejvyšší úroveň abstrakce) - Můj mozek ví, jakou kyselinu mám v žaludku, ale neříká mi to
 *                            - Protected = Vidí třídy a jejich podtřídy - Můj mozek ví, kde mám ruku a říká mi to
 *                            - Public = Vidí všichni - Všichni kdo chtějí věět kde mám ruku, to můžou zjistit
 * Inheritance (dědičnost) - Atributy se předávají z nadtřídy do podtřídy (superclass -> subclass)
 * Polymorfismus
 * 
 * 
 * [Tabulka Paměti - [[string - 8B]][[pointer - 8B]]]   [Jméno třídy] -> [Pointer]
 * [Definice třídy 36B - [Deklarace proměných - int -4B, int-4B, string-12B][Statické Proměnné][Statické Funkce]][Volné místo 4B][Instance - 20B][Instance - 20B][Instance - 20B]
 * 
 */


using OPP_Showcase;
using System;

class main
{
    static void Main(string[] args)
    {
        Console.WriteLine("RUN");
        Apple apple1 = new Apple(10, Apple.TYPES.GRANNY_SMITH, "sweet");
        Apple apple2 = new Apple(20, Apple.TYPES.GRANNY_SMITH, "bitter");
        Console.WriteLine(apple2.taste);
        Console.WriteLine(apple1.prt());
        Console.WriteLine(apple2.prt());
    }
}