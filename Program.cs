// See https://aka.ms/new-console-template for more information
/*int [] array = {1,0,8,13,5,4,546};
int[] a = Sort(array);*/
int[] colores={4,4,4,4};
int[] pos ={3,0,2,0};
int[] pista = {};
 
static int[]Simula(int[]colores,int[]pos, int[] pista){
//se espera {2}
for (int p= 0; p < pos.Length; p++)
{
  if (p>=pista.Length)
  {
   int[] pistapluscolores = new int[pista.Length+colores.Length];
  }
}

int[] indexes = findcombination(colores);
if(indexes.Length!=0){
int elements=indexes[1]-indexes[0];
int[] finalarray=new int[colores.Length-elements-1];
while (indexes.Length!=0)
{
  //hay al menos una combinacion, se llama a metodo para eliminarla y findcombination para ver si hay otra.
  finalarray = todeletecombination(colores, indexes[0], indexes[1]);
  indexes = findcombination(finalarray);
}
return finalarray;
}else{
  return colores;
}
}if(colores.Length!=0||Simula(colores).Length!=0){
foreach (var item in Simula(colores))
{
  System.Console.WriteLine(item);
}
}else


static int[] findcombination (int[] a){
    int inicio=0; int fin=0;
    
    for (int i = 0; i < a.Length-2; i++)
  { int amountofsamecolorballs = 1;
    for (int j = i+1; j < a.Length; j++)
    {
        if(a[i]==a[j])
        {
           amountofsamecolorballs++;
           if (amountofsamecolorballs>=3)
           {   inicio=i;
                fin=j;
           }
        }else{
          break;
          }

    } if(fin!=0){int [] indexes = {inicio,fin};
    return indexes;}
  } int[] empty = {}; 
  return empty;
}

static int[] todeletecombination(int[] a,int inicio,int fin){
  int [] a_modified= new int[a.Length-fin+inicio-1];
for (int i = 0; i < inicio; i++)
{
  a_modified[i]= a[i];
}
for (int j = inicio;j < a_modified.Length; j++)
{for(int h= fin+1;h<a.Length; h++)
  a_modified[j]= a[h];
}
return a_modified;
}


static int[] Insert (int[]pista, int itemincolores, int iteminpos){
  int[] copia = new int[pista.Length+1];
  for (int i = 0; i < iteminpos; i++)
  {
    copia[i] = pista[i];
    copia[iteminpos] = itemincolores;
    }
    for (int i = iteminpos; i < pista.Length; i++)
    {
     copia[i+1]=pista[i]; 
    }return copia;
  }







    