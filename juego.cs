#include <iostream>

int main() {
    char operacion;
    double num1, num2;

    std::cout << "Ingrese la operación (+, -, *, /): ";
    std::cin >> operacion;

    std::cout << "Ingrese dos números: ";
    std::cin >> num1 >> num2;

    switch (operacion) {
        case '+':
            std::cout << "Resultado: " << num1 + num2 << std::endl;
            break;
        case '-':
            std::cout << "Resultado: " << num1 - num2 << std::endl;
            break;
        case '*':
            std::cout << "Resultado: " << num1 * num2 << std::endl;
            break;
        case '/':
            if (num2 != 0)
                std::cout << "Resultado: " << num1 / num2 << std::endl;
            else
                std::cout << "Error: División por cero." << std::endl;
            break;
        default:
            std::cout << "Operación no válida." << std::endl;
    }

    return 0;
}
