Algoritmo EntradasEstadio
	Definir sector, cantidad Como Entero
	Definir precio, total Como Real
	
	Escribir "===== SECTORES DEL ESTADIO ====="
	Escribir "1. Palco (Q300.00)"
	Escribir "2. Tribuna (Q100.00 - Q125.00)"
	Escribir "3. Preferencia (Q50.00 - Q75.00)"
	Escribir "4. Generales (Q30.00 - Q50.00)"
	
	Escribir "Seleccione un sector:"
	Leer sector
	
	Escribir "Ingrese cantidad de entradas:"
	Leer cantidad
	
	Segun sector Hacer
		1:
			precio <- 300
		2:
			precio <- 112.5
		3:
			precio <- 62.5
		4:
			precio <- 40
		De Otro Modo:
			Escribir "Sector inválido"
			total <- 0
	Fin Segun
	
	total <- precio * cantidad
	
	Escribir "Total a pagar: Q", total
FinAlgoritmo