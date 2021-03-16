#include <iostream>
#include <string>
using namespace std;

int main()
{
    struct datosPersona
    {
        string nombre;
        char inicial;
        int edad;
        float nota;
    };
    datosPersona *persona = new datosPersona[50];
    for (int i = 0; i < 5; i++)
    {
        cout << "Dime el nombre de la persona " << i << endl;
        cin >> persona[i].nombre;
    }
    cout << "La persona 3 es " << persona[2].nombre << endl;
    return 0;
}