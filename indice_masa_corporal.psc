Algoritmo indice_masa_corporal
	Escribir 'Cuantas personas deseas ingresar?'
	Leer nPersonas
	i <- 1
	// arreglos
	Dimensionar nombres(nPersonas), peso(nPersonas), alturas(nPersonas), edades(nPersonas), imc(nPersonas)
	// ciclo para llenar datos
	Mientras i<=nPersonas Hacer
		Escribir 'Ingresa el nombre de la persona: '
		Leer nombres[i]
		Escribir 'Ingresa el peso en kg de la persona: '
		Leer peso[i]
		Escribir 'Ingresa su altura en metros: '
		Leer alturas[i]
		Escribir 'Ingresa su edad: '
		Leer edades[i]
		// formula para calcular el imc
		imc[i] <- (peso[i]/(alturas[i]*alturas[i]))
		i <- i+1
	FinMientras
	// recorremos el arreglo en busca del mayor indice de masa
	// empezamos suponiendo que la primer posicion de los arreglos es el dato que buscamos
	mayorIMC <- imc[1]
	nIMC <- nombres[1]
	Para j<-2 Hasta nPersonas Hacer
		Si imc[j]>mayorIMC Entonces
			mayorIMC <- imc[j]
			nIMC <- nombres[j]
		FinSi
	FinPara
	Escribir 'El mayor imc (', mayorIMC, ') lo obtuvo ', nIMC
	// recorremos el arreglo en busca de la persona màs alta
	mayorAltura <- alturas[1]
	nAltura <- nombres[1]
	Para j<-2 Hasta nPersonas Hacer
		Si alturas[j]>mayorAltura Entonces
			mayorAltura <- alturas[j]
			nAltura <- nombres[j]
		FinSi
	FinPara
	Escribir 'La persona mas alta (', mayorAltura, ' metros) fue ', nAltura
	// recorremos el arreglo en busca de la persona mas joven
	joven <- edades[1]
	nJoven <- nombres[1]
	Para j<-2 Hasta nPersonas Hacer
		Si edades[j]<joven Entonces
			joven <- edades[j]
			nJoven <- nombres[j]
		FinSi
	FinPara
	Escribir 'La persona mas joven (', joven, ' años) fue ', nJoven
FinAlgoritmo
