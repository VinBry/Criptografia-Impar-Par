using System;
using static System.Console;

namespace Zenit_Polar
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase, vLetra, Vresp, ZP;
            int i;

            do
            {
                Clear();

                WriteLine("Digite uma frase no campo de escrita abaixo, para que a mesma seja criptografada: Utilizando o Método Zenit-Polar:\n");
                frase = ReadLine();

                ZP = "";

                for (i = 0; i < frase.Length; i++)
                {
                    vLetra = frase.Substring(i, 1);

                    switch (vLetra.ToLower())
                    {
                        case "p":
                            {
                                ZP += "z";
                                break;
                            }

                        case "z":
                            {
                                ZP += "p";
                                break;
                            }

                        case "e":
                            {
                                ZP += "o";
                                break;
                            }

                        case "è":
                            {
                                ZP += "ò";
                                break;
                            }

                        case "é":
                            {
                                ZP += "ó";
                                break;
                            }

                        case "ê":
                            {
                                ZP += "ô";
                                break;
                            }

                        case "o":
                            {
                                ZP += "e";
                                break;
                            }
                        case "ó":
                            {
                                ZP += "é";
                                break;
                            }
                        case "ò":
                            {
                                ZP += "è";
                                break;
                            }
                        case "ô":
                            {
                                ZP += "ê";
                                break;
                            }

                        case "n":
                            {
                                ZP += "l";
                                break;
                            }

                        case "l":
                            {
                                ZP += "n";
                                break;
                            }


                        case "i":
                            {
                                ZP += "a";
                                break;
                            }

                        case "í":
                            {
                                ZP += "á";
                                break;
                            }

                        case "ì":
                            {
                                ZP += "à";
                                break;
                            }
                        case "a":
                            {
                                ZP += "i";
                                break;
                            }
                        case "á":
                            {
                                ZP += "í";
                                break;
                            }
                        case "à":
                            {
                                ZP += "ì";
                                break;
                            }

                        case "t":
                            {
                                ZP += "r";
                                break;
                            }

                        case "r":
                            {
                                ZP += "t";
                                break;
                            }

                        default:
                            {
                                ZP += vLetra;
                            }
                            break;

                    }

                }
                Clear();
                WriteLine($"De forma criptografada, o texto digitado ficara: \n" + (ZP.ToUpper()));

                WriteLine("\n\n\n\n\nDeseja reinicar o Programa?");
                Vresp = ReadLine();
            } while (Vresp == "Sim" || Vresp == "sim");
        }
    }
}
