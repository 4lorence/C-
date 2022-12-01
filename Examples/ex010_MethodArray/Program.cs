int[]array ={1,2,3,4,5,6,7,8,9,10};

int n =array.Length;
int find = 11;

int i = 0;

while(i < n)
{
    if(array[i] == find)
    {
        Console.WriteLine(i);
        break;
    }
    else
    {
        Console.WriteLine("Oops");
        break;
    }
    //index = index +1;
    i++;
}

