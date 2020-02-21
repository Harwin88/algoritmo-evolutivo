using System;
using System.Text;
namespace exmamen_mvm_in
{
    class Program
    {
        int[] vectoresCalifi = new int[50];
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
            public int[] buscarCharEnvector(char cara, int p){
                 string objetivo = "MVM INGENIERIA DE SOFTWARE";
                 int veces=0;
                 int[] pos = new int[5];
                  char[] cadeNaObj = objetivo.ToCharArray(0, 26);
                
                         if(cadeNaObj[p]== cara)
                         {
                            pos[veces]= p;
                            veces +=1;
                         }
                return pos;
            }
        public int califiDevec(string stringDatos){
          string objetivo = "MVM INGENIERIA DE SOFTWARE";
          char[] cadeLLegada = stringDatos.ToCharArray(0, 26);
            char[] cadeNaObj = objetivo.ToCharArray(0, 26);
                 int veces=0;
                for (int i = 0; i < 26; i++)
                     {
                         if(cadeNaObj[i]== cadeLLegada[i])
                         {
                             veces +=1;
                         }
                     }
               return veces;
        }

            static void Main(string[] args)
            {
              
                Program objPro =new Program();
                char[] cadenaInicial=objPro.initialCadena();
                char[,] vectCadenas = new char[27, 50];
                string respuesta = "";
                string[] cadenasNue = new string[50];
                Random rnd = new Random();
                int calificaCion=0;
                char letra;
                int totalCali=0;
                int[,] cuenta = new int[26, 50];
            for (int y = 0; y < 50; y++)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        letra = (char)rnd.Next('A', 'Z');
                         int[] poss= new  int[5];
                         //carateristica que hace mutar el algorigo es si la 
                         //letra generada esta en el vetor iinicial "mvm ingenieria..."
                         //realiza una busqueda de la letra en todo el vector.
                        poss = objPro.buscarCharEnvector(letra, i);
                       if(poss[0]!=null)
                        {
                            for(int j=0; j<= poss.Length-1; j++){
                               cadenaInicial[poss[j]] = letra;
                               
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
                           int valVt= objPro.califiDevec(respue);
                           
                            System.Console.WriteLine("Generación: "+y+"-"+respue+"- Puntaje: "+valVt);
                            if(valVt==26){
                               y=49;
                           }else{
                               //vuelve a generar las cadenas asta optener una
                               //mutacion perfecta.
                               if(y==49){
                                   System.Console.WriteLine("---interaciones---");
                                    y=0;
                               }
                           }
                            totalCali=0;
                        respuesta = "";
                      System.Console.WriteLine(cadenasNue[y]);
                    }
                    
                   
                }
             
        }
    }
