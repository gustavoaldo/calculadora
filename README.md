# Calculadora .NET 10

Una aplicación de escritorio en .NET 10 que permite realizar operaciones matemáticas básicas con números enteros.

## Características

- Suma de dos números enteros
- Resta de dos números enteros
- Multiplicación de dos números enteros
- Interfaz interactiva en consola
- Validación de entrada de datos
- Capacidad de realizar múltiples operaciones en una sesión

## Requisitos

- .NET 10.0 SDK o superior

## Instalación

1. Clonar el repositorio:
```bash
git clone https://github.com/gustavoaldo/calculadora.git
cd calculadora
```

2. Restaurar dependencias:
```bash
dotnet restore
```

3. Compilar el proyecto:
```bash
dotnet build
```

## Uso

Ejecutar la aplicación:
```bash
dotnet run
```

La calculadora le pedirá:
1. Ingresar el primer número entero
2. Ingresar el segundo número entero
3. Seleccionar la operación deseada:
   - 1 para Suma (+)
   - 2 para Resta (-)
   - 3 para Multiplicación (*)
4. El resultado se mostrará en pantalla
5. Opción para realizar otra operación o salir

## Ejemplo de uso

```
====================================
     CALCULADORA .NET 10
====================================

Ingrese el primer número entero: 10
Ingrese el segundo número entero: 5

Seleccione la operación:
1. Suma (+)
2. Resta (-)
3. Multiplicación (*)
Ingrese su opción (1-3): 1

====================================
  RESULTADO: 10 + 5 = 15
====================================

¿Desea realizar otra operación? (S/N):
```

## Estructura del proyecto

- `Program.cs`: Archivo principal con la lógica de la calculadora
- `Calculadora.csproj`: Archivo de configuración del proyecto .NET
- `.gitignore`: Archivos y carpetas excluidos del control de versiones

## Tecnologías utilizadas

- .NET 10.0
- C# 12
- Console Application