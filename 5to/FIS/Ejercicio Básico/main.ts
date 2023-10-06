import * as readline from "readline";

// Colores de texto ANSI
const resetColor = "\x1b[0m"; // Restablecer el color a su valor predeterminado
const redColor = "\x1b[31m"; // Rojo
const greenColor = "\x1b[32m"; // Verde
const blueColor = "\x1b[34m"; // Azul
const yellowColor = "\x1b[33m"; // Amarillo

// Definición de la tasa de conversión
const tasaConversion = 1.5;

// Función para convertir CAD a euros
const cadAEuro = (montoCAD: number): number => {
    return montoCAD / tasaConversion;
};

// Función para convertir euros a CAD
const euroACAD = (montoEuro: number): number => {
    return montoEuro * tasaConversion;
};

// Crear una interfaz de lectura y escritura
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
});

const menu = () => {
    rl.question(`Selecciona una opción ${yellowColor}(1/2)${resetColor}: `, (opcion) => {
        if (opcion === "1") {
            rl.question("Ingresa la cantidad de CAD a convertir: ", (montoCAD) => {
                const resultadoEuro = cadAEuro(Number(montoCAD));
                console.log(`${montoCAD} CAD equivale a ${resultadoEuro} euros.`);
                rl.close();
            });
        } else if (opcion === "2") {
            rl.question("Ingresa la cantidad de euros a convertir: ", (montoEuro) => {
                const resultadoCAD = euroACAD(Number(montoEuro));
                console.log(`${montoEuro} euros equivale a ${resultadoCAD} CAD.`);
                rl.close();
            });
        } else {
            console.log(`${redColor}Opción inválida.${resetColor}`);
            menu();
        }
    });
};

// Función principal
function main() {
    console.log(
        `${blueColor}Bienvenido al conversor de divisas: ${greenColor}Dólar Canadience (CAD) <-> Euro${resetColor}\n`
    );

    // Solicitar al usuario la dirección de conversión
    console.log(`${yellowColor}Selecciona la dirección de conversión:${resetColor}`);
    console.log(`${yellowColor}1.${resetColor} CAD -> Euro`);
    console.log(`${yellowColor}2.${resetColor} Euro -> CAD`);

    menu();
}

// Ejecutar la función principal
main();
