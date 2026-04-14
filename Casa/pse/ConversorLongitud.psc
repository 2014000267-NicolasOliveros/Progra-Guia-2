Algoritmo ConversorLongitud
	Definir opcion Como Entero
	Definir valor Como Real
	
	Escribir "===== CONVERSOR DE LONGITUD ====="
	Escribir "1. Metros"
	Escribir "2. Pies"
	Escribir "3. Centímetros"
	Escribir "4. Pulgadas"
	
	Escribir "Seleccione una opción:"
	Leer opcion
	
	Escribir "Ingrese el valor:"
	Leer valor
	
	Segun opcion Hacer
		1:
			Escribir "En pies: ", valor * 3.28084
			Escribir "En centímetros: ", valor * 100
			Escribir "En pulgadas: ", valor * 39.3701
		2:
			Escribir "En metros: ", valor * 0.3048
			Escribir "En centímetros: ", valor * 30.48
			Escribir "En pulgadas: ", valor * 12
		3:
			Escribir "En metros: ", valor * 0.01
			Escribir "En pies: ", valor * 0.0328084
			Escribir "En pulgadas: ", valor * 0.393701
		4:
			Escribir "En metros: ", valor * 0.0254
			Escribir "En pies: ", valor * 0.0833333
			Escribir "En centímetros: ", valor * 2.54
		De Otro Modo:
			Escribir "Opción inválida"
	Fin Segun
FinAlgoritmo