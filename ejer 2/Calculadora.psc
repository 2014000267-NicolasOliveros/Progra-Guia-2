Algoritmo Calculadora
	Definir opc, n1, n2 Como Entero
	Definir res Como Real
	
	Escribir "**************************"
	Escribir "***  MENÚ DE OPCIONES  ***"
	Escribir "**************************"
	Escribir "1 - Suma"
	Escribir "2 - Resta"
	Escribir "3 - Multiplicación"
	Escribir "4 - División"
	
	Leer opc
	Escribir "Digite dos valores numericos"
	Leer n1
	leer n2
	Segun opc Hacer
		1:
			res = n1+n2
			Escribir "La suma es: ",res
		2:
			res = n1-n2
			Escribir "La resta es: ",res
		3:
			res = n1*n2
			Escribir "La multiplicacion: ",res
		4:
			res = n1/n2
			Escribir "La division es: ",res
		De Otro Modo:
			Escribir "Error al operar"
	Fin Segun
FinAlgoritmo
