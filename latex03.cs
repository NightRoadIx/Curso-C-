#include <iostream>
#include <bitset>
using namespace std;

const unsigned char BARRERA      = 1 << 0; // bit0
const unsigned char TEMP_ALTA    = 1 << 1; // bit1
const unsigned char PUERTA_ABIERTA=1 << 2; // bit2
const unsigned char EMERGENCIA   = 1 << 3; // bit3

void ver(unsigned char est) {
    cout << "estado -> " << bitset<8>(est) << "\n";
}

int main() {
    unsigned char estado = 0; // 0000 0000
    ver(estado);

    // Activar barrera y temperatura alta:
    estado |= BARRERA;
    estado |= TEMP_ALTA;
    ver(estado);

    // ¿Puerta abierta?
    cout << "Puerta abierta? " << ((estado & PUERTA_ABIERTA) ? "SI" : "NO") << "\n";

    // Llega señal de emergencia:
    estado |= EMERGENCIA;
    ver(estado);

    // Se cierra puerta (asegurar bit en 0):
    estado &= ~PUERTA_ABIERTA; // ya estaba en 0, no pasa nada
    ver(estado);

    // Apagar temperatura alta:
    estado &= ~TEMP_ALTA;
    ver(estado);
}
