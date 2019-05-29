#include <stdio.h>
#include <stdlib.h>

void inicializar(int x, int y, int[x][y]);
int nuevaCarta(int[40]);
int cantidadJugadores();
void mostrarTotales(int x, int[x][15],int i);
int mostrarCartas(int x, int[x][15],int i);

int main() {
	int jugadores,  mazo[40]= {0}, juega, carta, seguir, pos;
	char salir;

	jugadores = cantidadJugadores();
	int cartas[jugadores][15];
	inicializar(jugadores,15,cartas);

	for(juega = 0; juega<jugadores -1; juega++) {
		seguir =1;
		pos = 0;
		while(seguir==1) {
			system("cls");
			mostrarTotales(jugadores,cartas,juega);
			carta = nuevaCarta(mazo);
			mazo[carta] = 1;
			cartas[juega][pos] = carta+1;
			seguir = mostrarCartas(jugadores,cartas, juega);
			pos++;
			if(seguir==1 ) {
				printf("\n Desea otra Carta? (s/n) ");
				salir = toupper(getche());
				while(salir != 'S' && salir != 'N') {
					printf("\n Desea otra Carta? (s/n) ");
					salir = toupper(getche());
				}
				if (salir == 'N')
					seguir =0;
			}

		}
	}

system("pause");

	return(0);
}

void inicializar(int x, int y, int cartas[x][y]) {
	int i,j;
	for (i=0; i<x; i++)
		for (j=0; j<y; j++)
			cartas[i][j]= 0;
}

int nuevaCarta(int mazo[40]) {
	int carta, salida = 1,i;
	time_t t;
	srand((unsigned) time(&t));
	while(salida == 1) {
		carta = (rand() % 40)  ;
		salida = mazo[carta];
	}

	return carta;
}

int cantidadJugadores() {
	int cant;
	printf("¿Cuantos jugadores juegan (1-4)?");
	fflush(stdin);
	scanf("%d",&cant);
	while (cant<0 || cant > 4) {
		printf("Cantidad invalida, de 1 a 4 jugadores:");
		fflush(stdin);
		scanf("%d",&cant);
	}

	return cant + 1 ;
}

void mostrarTotales(int x, int cartas[x][15],int jug) {
	int i,j,t;
	float suma[x];

	for(i=0; i<jug; i++) {
		printf(" Jugador %d   ",i+1);
		suma[i]=0;
	}
	for (j= 0; j<15; j++) {
		t = 0;
		for(i=0; i<jug; i++) {
			t=t+cartas[i][j];
		}
		if (t>0) {
			printf("\n");
			for(i=0; i<jug; i++) {
				if(cartas[i][j]!=0) {
					printf(" %c%c%c%c%c%c     ",219,219,219,219,219,219);
				} else {
					printf("            ");
				}
			}
			printf("\n");
		}
		for(i=0; i<jug; i++) {
			if(cartas[i][j]!=0) {
				switch(cartas[i][j]/10) {
					case 0:
						switch(cartas[i][j]%10) {
							case 9:
								printf(" %c 12%c%c     ",219,4,219);
								suma[i]=suma[i]+0.5;
								break;
							case 8:
								printf(" %c 11%c%c     ",219,4,219);
								suma[i]=suma[i]+0.5;
								break;
							case 7:
								printf(" %c 10%c%c     ",219,4,219);
								suma[i]=suma[i]+0.5;
								break;
							default:
								printf(" %c %d %c%c     ",219,(cartas[i][j]%10)+1,4,219);
								suma[i]=suma[i]+(cartas[i][j]%10)+1;
								break;
						}
						break;
					case 1:
						switch(cartas[i][j]%10) {
							case 9:
								printf(" %c 12%c%c     ",219,5,219);
								suma[i]=suma[i]+0.5;
								break;
							case 8:
								printf(" %c 11%c%c     ",219,5,219);
								suma[i]=suma[i]+0.5;
								break;
							case 7:
								printf(" %c 10%c%c     ",219,5,219);
								suma[i]=suma[i]+0.5;
								break;
							default:
								printf(" %c %d %c%c     ",219,(cartas[i][j]%10)+1,5,219);
								suma[i]=suma[i]+(cartas[i][j]%10)+1;
								break;
						}
						break;
					case 2:
						switch(cartas[i][j]%10) {
							case 9:
								printf(" %c 12%c%c     ",219,6,219);
								suma[i]=suma[i]+0.5;
								break;
							case 8:
								printf(" %c 11%c%c     ",219,6,219);
								suma[i]=suma[i]+0.5;
								break;
							case 7:
								printf(" %c 10%c%c     ",219,6,219);
								suma[i]=suma[i]+0.5;
								break;
							default:
								printf(" %c %d %c%c     ",219,(cartas[i][j]%10)+1,6,219);
								suma[i]=suma[i]+(cartas[i][j]%10)+1;
								break;
						}
						break;
					case 3:
						switch(cartas[i][j]%10) {
							case 9:
								printf(" %c 12%c%c     ",219,3,219);
								suma[i]=suma[i]+0.5;
								break;
							case 8:
								printf(" %c 11%c%c     ",219,3,219);
								suma[i]=suma[i]+0.5;
								break;
							case 7:
								printf(" %c 10%c%c     ",219,3,219);
								suma[i]=suma[i]+0.5;
								break;
							default:
								printf(" %c %d %c%c     ",219,(cartas[i][j]%10)+1,3,219);
								suma[i]=suma[i]+(cartas[i][j]%10)+1;
								break;
						}
						break;
				}


			} else {
				printf("            ");
			}
		}
	}
	printf("\n");
	for(i=0; i<jug; i++) {
		printf("Puntos %2.1f  ",suma[i]);

	}
}

int mostrarCartas(int x, int cartas[x][15],int jug) {

	int i;
	float suma=0;

	printf("\n");
	printf("\n");
	for(i=0; i<15; i++) {
		if(cartas[jug][i]!= 0)
			printf(" %c%c%c%c%c%c   ",219,219,219,219,219,219);
	}
	printf("\n");
	for(i=0; i<15; i++) {
		if(cartas[jug][i]!= 0) {
			switch(cartas[jug][i]/10) {
				case 0:
					switch(cartas[jug][i]%10) {
						case 9:
							printf(" %c 12%c%c   ",219,4,219);
							suma=suma+0.5;
							break;
						case 8:
							printf(" %c 11%c%c   ",219,4,219);
							suma=suma+0.5;
							break;
						case 7:
							printf(" %c 10%c%c   ",219,4,219);
							suma=suma+0.5;
							break;
						default:
							printf(" %c %d %c%c   ",219,(cartas[jug][i]%10)+1,4,219);
							suma=suma+(cartas[jug][i]%10)+1;
							break;
					}
					break;
				case 1:
					switch(cartas[jug][i]%10) {
						case 9:
							printf(" %c 12%c%c   ",219,5,219);
							suma=suma+0.5;
							break;
						case 8:
							printf(" %c 11%c%c   ",219,5,219);
							suma=suma+0.5;
							break;
						case 7:
							printf(" %c 10%c%c   ",219,5,219);
							suma=suma+0.5;
							break;
						default:
							printf(" %c %d %c%c   ",219,(cartas[jug][i]%10)+1,5,219);
							suma=suma+(cartas[jug][i]%10)+1;
							break;
					}
					break;
				case 2:
					switch(cartas[jug][i]%10) {
						case 9:
							printf(" %c 12%c%c   ",219,6,219);
							suma=suma+0.5;
							break;
						case 8:
							printf(" %c 11%c%c   ",219,6,219);
							suma=suma+0.5;
							break;
						case 7:
							printf(" %c 10%c%c   ",219,6,219);
							suma=suma+0.5;
							break;
						default:
							printf(" %c %d %c%c   ",219,(cartas[jug][i]%10)+1,6,219);
							suma=suma+(cartas[jug][i]%10)+1;
							break;
					}
					break;
				case 3:
					switch(cartas[jug][i]%10) {
						case 9:
							printf(" %c 12%c%c   ",219,3,219);
							suma=suma+0.5;
							break;
						case 8:
							printf(" %c 11%c%c   ",219,3,219);
							suma=suma+0.5;
							break;
						case 7:
							printf(" %c 10%c%c   ",219,3,219);
							suma=suma+0.5;
							break;
						default:
							printf(" %c %d %c%c   ",219,(cartas[jug][i]%10)+1,3,219);
							suma=suma+(cartas[jug][i]%10)+1;
							break;
					}
					break;
			}
		}

	}
	printf("\n");
	for(i=0; i<15; i++) {
		if(cartas[jug][i]!= 0)
			printf(" %c    %c   ",219,219);
	}
	printf("\n");
	for(i=0; i<15; i++) {
		if(cartas[jug][i]!= 0)
			printf(" %c%c%c%c%c%c   ",219,219,219,219,219,219);
	}
	printf("\n\n Total: %.1f",suma);

	if(suma>7.5)
		return 0;
	return 1;

}
