﻿// See https://aka.ms/new-console-template for more information

using Calculadora;

int opc=-1;

var menu = new Menu();

while(opc != 7)
{
    opc = menu.InpOption();
    menu.SelectOption(opc);
}