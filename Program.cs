﻿namespace Ejercicio_2;

class Program {
    static void Main(string[] args) {

        Menu menu = new Menu();

        bool MostrarMenu = true;

        while(MostrarMenu){

            MostrarMenu = menu.ShowMenu();
        }
    }
}
