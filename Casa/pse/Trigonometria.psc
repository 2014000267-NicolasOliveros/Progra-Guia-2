Algoritmo Trigonometria
	Definir opc, a, rad, res Como Real
	
	Escribir "**************************"
	Escribir "***  MENÚ DE OPCIONES  ***"
	Escribir "**************************"
	Escribir "1 - Seno"
	Escribir "2 - Coseno"
	Escribir "3 - Tangente"
	
	Leer opc
	Escribir "Digite su angulo:"
	Leer a
	rad= a*(pi/180)
	Segun opc Hacer
		1:
			res = sen(rad)
			Escribir "Seno: ",res
		2:
			res = cos(rad)
			Escribir "Coseno: ",res
		3:
			res = tan(rad)
			Escribir "Tangente: ",res
		De Otro Modo:
			Escribir "Error al operar"
	Fin Segun
FinAlgoritmo