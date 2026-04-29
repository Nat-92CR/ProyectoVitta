# Proyecto Vitta — Iteración II (v2)

Sistema de gestión nutricional desarrollado en **C# (.NET 9)** con **Blazor Server**, basado en arquitectura **MVC** y persistencia local en archivos **CSV**. Proyecto académico del curso de **Técnicas de Programación** — Universidad Politécnica Internacional.

> **Versión actual:** Iteración II (Proyecto #2) — migración de Windows Forms a Blazor Server e incorporación del módulo de administración con estadísticas globales del sistema.

---

## Tabla de contenidos

- [Descripción](#descripción)
- [Stack tecnológico](#stack-tecnológico)
- [Estructura de la solución](#estructura-de-la-solución)
- [Funcionalidades](#funcionalidades)
- [Cómo ejecutar el proyecto](#cómo-ejecutar-el-proyecto)
- [Credenciales por defecto](#credenciales-por-defecto)
- [Cómo correr las pruebas](#cómo-correr-las-pruebas)
- [Persistencia y datos sembrados](#persistencia-y-datos-sembrados)
- [Documentación](#documentación)
- [Planificación del proyecto](#planificación-del-proyecto)
- [Autora](#autora)

---

## Descripción

Vitta permite a una persona usuaria registrar sus comidas diarias, consultar información nutricional, calcular su Índice de Masa Corporal (IMC), conocer sus calorías de mantenimiento y obtener una distribución estimada de macronutrientes según su objetivo, nivel de actividad y tipo de dieta.

En la Iteración II, el sistema se migró de Windows Forms a una aplicación web con **Blazor Server**, conservando intactos los controladores y modelos. Se incorporó un **panel de administración** completo con gestión de usuarios, gestión de alimentos y estadísticas globales del sistema, y se ampliaron significativamente las pruebas unitarias (**69 tests** con MSTest + Moq).

---

## Stack tecnológico

- **.NET 9.0** — runtime y SDK.
- **Blazor Server** — interfaz web con renderizado interactivo (`@rendermode InteractiveServer`).
- **C# 12** — lenguaje principal.
- **MSTest + Moq** — pruebas unitarias con dependencias mockeadas.
- **SonarAnalyzer.CSharp** — análisis estático de código y buenas prácticas.
- **CSV** — persistencia local (sin base de datos relacional).

---

## Estructura de la solución

La solución `Vitta.sln` contiene cinco proyectos que reflejan la separación por capas del patrón MVC:

```
ProyectoVitta/
├── src/
│   ├── VittaModel/          # Entidades del dominio (User, Food, DailyMenu, NutritionInfo)
│   ├── VittaController/     # Lógica de negocio + Strategy de dietas + FileHandler<T>
│   ├── VittaBlazor/         # Aplicación web Blazor Server (interfaz oficial v2)
│   └── VittaView/           # Aplicación de consola (respaldo / referencia)
├── test/
│   └── VittaControllerTest/ # Pruebas unitarias MSTest + Moq (69 tests)
├── data/
│   ├── users.csv
│   ├── foods.csv
│   └── menus.csv
├── docs/                    # Documentación técnica final del proyecto
├── README.md
└── Vitta.sln
```

---

## Funcionalidades

### Usuario regular

- Inicio de sesión y registro.
- Consulta y actualización del perfil personal.
- Registro y modificación de menús diarios por tiempo de comida.
- Consulta del catálogo de alimentos.
- Cálculo de IMC, calorías de mantenimiento y distribución de macronutrientes según el tipo de dieta (Estándar / Vegetariana / Keto) — patrón **Strategy**.
- Estadísticas individuales (día, rango de fechas, total de menús).
- Descarga de reportes nutricionales en formato CSV y TXT.

### Administrador

- Panel principal diferenciado del usuario regular.
- Administración de alimentos (CRUD completo).
- Administración de usuarios: registrar, buscar, restablecer contraseña, cambiar rol y activar/desactivar (soft delete vía `IsActive`).
- Estadísticas globales del sistema:
  - Alimento más registrado por todos los usuarios.
  - Total de usuarios, usuarios con menús cargados y menús registrados.
  - Distribución porcentual de tipos de dieta.
  - Ranking de usuarios con más menús registrados.

---

## Cómo ejecutar el proyecto

### Requisitos previos

- SDK de **.NET 9** instalado ([descargar](https://dotnet.microsoft.com/download/dotnet/9.0)).
- Visual Studio 2022 (17.10+) **o** Visual Studio Code con la extensión *C# Dev Kit*.
- Sistema operativo: Windows 10/11, macOS o Linux.
- Un navegador moderno (Edge, Chrome o Firefox).

### Pasos

```bash
# 1. Clonar el repositorio
git clone https://github.com/Nat-92CR/ProyectoVitta.git
cd ProyectoVitta

# 2. Restaurar paquetes NuGet
dotnet restore

# 3. Compilar la solución
dotnet build

# 4. Ejecutar la aplicación web Blazor
dotnet run --project src/VittaBlazor
```

La aplicación abrirá en `https://localhost:5001` (o el puerto que muestre la consola). La pantalla inicial es el inicio de sesión.

> **Tip:** desde Visual Studio basta con marcar `VittaBlazor` como proyecto de inicio y pulsar **F5**.

---

## Credenciales por defecto

El repositorio incluye un usuario administrador preconfigurado para que la aplicación pueda probarse de inmediato sin tener que crear cuentas:

| Rol           | Usuario | Contraseña  |
|---------------|---------|-------------|
| Administrador | `admin` | `admin123`  |

Adicionalmente, el archivo `data/users.csv` contiene 27 usuarios regulares con menús cargados durante un trimestre completo, lo cual permite visualizar de inmediato el funcionamiento de las **estadísticas globales** desde el panel de administración.

---

## Cómo correr las pruebas

El proyecto `VittaControllerTest` contiene **69 pruebas unitarias** que validan el comportamiento de cada controlador usando Moq para reemplazar el acceso al sistema de archivos:

```bash
dotnet test
```

Distribución de los tests por controlador:

| Archivo                              | Tests |
|--------------------------------------|-------|
| `FoodControllerTest.cs`              | 12    |
| `LoginControllerTest.cs`             | 5     |
| `MenuControllerTest.cs`              | 12    |
| `NutritionInfoControllerTest.cs`     | 17    |
| `StatisticsControllerTest.cs`        | 14    |
| `UserControllerTest.cs`              | 9     |
| **Total**                            | **69**|

Las pruebas cubren casos felices, casos límite y validaciones de error (login con credenciales incorrectas, registros duplicados, cálculos con valores extremos, agregación de estadísticas con CSVs vacíos, etc.).

---

## Persistencia y datos sembrados

La persistencia se realiza en archivos CSV ubicados en `data/`:

- `users.csv` — usuarios del sistema (incluye `IsActive` e `IsAdmin`).
- `foods.csv` — catálogo de alimentos con información nutricional.
- `menus.csv` — menús diarios registrados por los usuarios.

El acceso a estos archivos está encapsulado en la clase genérica `FileHandler<T>`, que gestiona lectura, escritura y agregación, dejando a los controladores libres de detalles de I/O.

**Volumen de datos sembrados:**

- 28 usuarios (1 administrador + 27 regulares).
- 16 usuarios con menús cargados.
- 84 alimentos en el catálogo.
- 453 menús diarios registrados.
- Cobertura temporal: 28/01/2026 a 28/04/2026 (3 meses).

---

## Documentación

La documentación técnica final del proyecto se encuentra en la carpeta `docs/`:

- `Documentacion_Final_Vitta_v2.pdf` — documento entregable del Proyecto #2.

El documento incluye: portada, índice, decisiones de diseño, descripción de cada módulo, instrucciones de uso/ejecución, análisis de resultados, aprendizajes, conclusiones y bibliografía.

---

## Planificación del proyecto

La planificación se gestionó en **Trello** mediante una estructura basada en *Epic → Features → Product Backlog Items (PBIs) → Tareas de implementación*.

- **Tablero de Trello:** [Proyecto Sistema de Gestión Nutricional Vitta](https://trello.com/b/3z5MMCwt/proyecto-sistema-de-gestion-nutricional-vitta)

---

## Autora

**Natalia Tobal D.**
Curso: Técnicas de Programación
Profesor: Luis Felipe Mora Umaña
Universidad Politécnica Internacional — abril de 2026

---

## Versión

**Proyecto Vitta — Iteración II (v2)** — entrega final 28 de abril de 2026.
