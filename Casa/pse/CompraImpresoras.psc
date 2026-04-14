Algoritmo CompraImpresoras
	Definir cantidad, opcion Como Entero
	Definir precioBase, iva, precioConIVA, totalSinDescuento, descuento, totalPagar Como Real
	Definir formaPago Como Caracter
	
	precioBase <- 650
	iva <- 0.12
	
	Escribir "Cantidad de impresoras:"
	Leer cantidad
	
	Escribir "Forma de pago:"
	Escribir "1. Efectivo (10%)"
	Escribir "2. Tarjeta de crédito (5%)"
	Escribir "3. Vale de regalo (15%)"
	
	Escribir "Seleccione una opción:"
	Leer opcion
	
	precioConIVA <- precioBase + (precioBase * iva)
	totalSinDescuento <- precioConIVA * cantidad
	
	Segun opcion Hacer
		1:
			formaPago <- "Efectivo"
			descuento <- totalSinDescuento * 0.10
		2:
			formaPago <- "Tarjeta de crédito"
			descuento <- totalSinDescuento * 0.05
		3:
			formaPago <- "Vale de regalo"
			descuento <- totalSinDescuento * 0.15
		De Otro Modo:
			Escribir "Opción inválida"
Fin Segun

totalPagar <- totalSinDescuento - descuento

Escribir "Cantidad: ", cantidad
Escribir "Precio unitario con IVA: Q", precioConIVA
Escribir "Total sin descuento: Q", totalSinDescuento
Escribir "Forma de pago: ", formaPago
Escribir "Descuento: Q", descuento
Escribir "Total a pagar: Q", totalPagar
FinAlgoritmo