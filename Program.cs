// 19

#include <stdio.h>
int main() {
  int n, reversed = 0, remainder, original;
    printf("Enter an integer: ");
    scanf("%d", &n);
    original = n;

    // reversed integer is stored in reversed variable
    while (n != 0) {
        remainder = n % 10;
        reversed = reversed * 10 + remainder;
        n /= 10;
    }

    // palindrome if orignal and reversed are equal
    if (original == reversed)
        printf("%d is a palindrome.", original);
    else
        printf("%d is not a palindrome.", original);

    return 0;
}

// 20

void distance(float x1, float y1,
            float z1, float x2,
            float y2, float z2)
{
    float d = sqrt(pow(x2 - x1, 2) +
                pow(y2 - y1, 2) +
                pow(z2 - z1, 2) * 1.0);
    std::cout << std::fixed;
    std::cout << std::setprecision(2);
    cout << " Distance is " << d;
    return;
}
 
int main()
{
    float x1 = 2;
    float y1 = -5;
    float z1 = 7;
    float x2 = 3;
    float y2 = 4;
    float z2 = 5;
     

    distance(x1, y1, z1,
            x2, y2, z2);
    return 0;
}

// 21

int main()
{
    int n,i=1;
    cout<<"Enter the range of number(Limit):";
    cin>>n;
    while(i<=n)
    {
     cout<<i*i*i<<" ";
     i++;
    }
}