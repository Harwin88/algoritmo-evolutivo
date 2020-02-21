using System;
using System.Text;
namespace exmamen_mvm_in
{
    class Program
    {

        public char[] initialCadena()
        {
            char[] vectCadenas = new char[26];
            char  letra;
            Random rnd = new Random();
            for (int i = 0; i < 26; i++)
            {
                letra = (char)rnd.Next('a', 'z');
                if (i == 3 || i == 14 || i == 17)
                {
                    vectCadenas[i] = ' ';

                }
                else
                {
                    vectCadenas[i] = letra;
                }
            }
                return vectCadenas;
            }
            //compara vectores con tamaños iguales 
            public int[] buscarCharEnvector(char cara){
                 string objetivo = "MVM INGENIERIA DE SOFTWARE";
                 int veces=0;
                 int[] pos = new int[5];
                  char[] cadeNaObj = objetivo.ToCharArray(0, 26);
                  for (int i = 0; i < 26; i++)
                     {
                         if(cadeNaObj[i]== cara)
                         {
                            pos[veces]= i;
                            veces +=1;
                         }
                     }
               return pos;
            }

            static void Main(string[] args)
            {
              
                Program objPro =new Program();
                char[] cadenaInicial=objPro.initialCadena();
                char[,] vectCadenas = new char[27, 50];
                string respuesta = "";
                string[] cadenasNue = new string[50];
                Random rnd = new Random();
              
                char letra;
                int[,] cuenta = new int[26, 50];
            for (int y = 0; y < 200; y++)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        letra = (char)rnd.Next('A', 'Z');
                         int[] poss= new  int[5];
                         //carateristica que hace mutar el algorigo es si la 
                         //letra generada esta en el vetor iinicial "mvm ingenieria..."
                         //realiza una busqueda de la letra en todo el vector.
                        poss = objPro.buscarCharEnvector(letra);
                       if(poss[0]!=null)
                        {
                            for(int j=0; j<= poss.Length; j++){
                           cadenaInicial[poss[j]] = letra;
                           System.Console.WriteLine(letra);
                             }
                        }else{
                                 vectCadenas[i, y] = cadenaInicial[i];
                        }
                            vectCadenas[i, y] = cadenaInicial[i];
                            respuesta = vectCadenas[i, y] + respuesta;
                        }
                          char[] charArray = respuesta.ToCharArray();
                          Array.Reverse( charArray );
                          string respue= new string( charArray );

                        System.Console.WriteLine(respue);
                        respuesta = "";
                      System.Console.WriteLine(cadenasNue[y]);
                    }
                    
                   
                }
             
        }
    }
