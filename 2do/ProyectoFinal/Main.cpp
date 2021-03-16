#include <iostream>
#include <string>
using namespace std;

int main() {
    string texto = "";
    int opcion = 0, tabla = 0, temp;
    bool validar = false, regresar = false;

    do {
        do {
            cout << "##### Tablas de multiplicar #####\n\n1.- Mostrar una tabla específica\n2.- Mostrar tablas del 1 – 10\n3.- Salir\n";
            cin >> opcion;

            if (!isdigit(opcion)) {
                validar = true;
            }
            else {
                cout << "La opcion no es valida.\n";
                validar = false;
            }
        } while (!validar);
        validar = false;

        if (opcion == 1) {
            do {
                do {
                    texto = "";
                    cout << "Indique el número de la tabla a mostrar: ";
                    cin >> tabla;

                    if (!isdigit(tabla)) {
                        validar = true;
                    }
                    else {
                        cout << "La opcion no es valida.\n";
                        validar = false;
                    }
                } while (!validar);
                validar = false;

                for (int i = 1; i <= 10; i++) {
                    texto += to_string(tabla) + " x " + to_string(i) + " = " + to_string(tabla*i) + "\n";
                }

                cout << texto;
                do {
                    cout << "¿Desea mostrar una nueva tabla (1. Si, 2. No)?\n";
                    cin >> temp;

                    if (!isdigit(temp)) {
                        if (temp == 1) {
                            regresar = false;
                            validar = true;
                        } else if (temp == 2) {
                            regresar = true;
                            validar = true;
                        } else cout << "La opcion no es valida.\n";
                    }
                    else {
                        cout << "La opcion no es valida.\n";
                        validar = false;
                    }
                } while (!validar);
            } while (!regresar);
        } else if (opcion == 2) {
            texto = "";
            for (int u = 1; u <= 10; u++) {
                for (int i = 1; i <= 10; i++) {
                    texto += to_string(u) + " x " + to_string(i) + " = " + to_string(u*i) + "\n";
                }
                texto += "\n";
            }
            cout << texto;
        } else if (opcion > 3 || opcion < 1) cout << "La opcion no es valida.\n";
    } while (opcion != 3);
    cout << "Cerrando programa... Hasta luego.\n";
}
