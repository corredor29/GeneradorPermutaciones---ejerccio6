# Generador de permutaciones de una cadena (C#)

## Descripción

Este programa en C# para consola genera todas las permutaciones posibles de una cadena de caracteres.

Una permutación es una reorganización de los caracteres donde el orden sí importa.

---

## Ejemplo

### Entrada

```id="k3m9qs"
abc
```

### Salida

```id="n8v2xp"
abc
acb
bac
bca
cab
cba
```

---

## Funcionamiento

El programa utiliza recursividad para construir todas las combinaciones posibles:

1. Toma un carácter de la cadena
2. Lo agrega al prefijo
3. Genera nuevas permutaciones con el resto de caracteres
4. Repite hasta que no queden caracteres

---

## Estructura

### Método principal

```id="y4p1rt"
Permutaciones(string Texto)
```

### Método recursivo

```id="d6w8az"
GenerarPermutaciones(string Prefijo, string Resto, List<string> Resultado)
```

---

## Complejidad

* Tiempo: **O(n!)** (factorial)
* Espacio: **O(n!)**

---

## Tecnologías usadas

* C#
* .NET
* Consola

---

## Autor

Felipe Corredor
Ejercicio de recursividad y backtracking