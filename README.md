# PFC-MundiPets-MDD-EquipoG

Exposición-demostración del **Segundo Corte**: Herramientas CASE (Visual Paradigm) aplicadas al ciclo de **Desarrollo Dirigido por Modelos (MDD)** sobre el sistema del PFC **MundiPets**.

**Materia:** Ingeniería de Requisitos — UTEQ
**Docente:** Ing. Guerrero Ulloa Gleiston Cicerón, PhD.
**Equipo G — Cuarto Semestre de Ingeniería en Software "B"**

## Integrantes

| Integrante | Rol |
|---|---|
| Fuertes Arraes Edson Daniel | Líder e integrador — Modelado UML y generación de código |
| Cedeño Avila Winston Damian | Marco teórico, descripción del subsistema y conclusiones |
| Cedeño Coronado Wilson Lizandro | Justificación de la herramienta MDD |

## Descripción

Este repositorio evidencia el ciclo completo MDD (UML → código) sobre el subsistema de **gestión del perfil de mascota y validación de información médica** de MundiPets. A partir de un diagrama de clases modelado en Visual Paradigm se genera código C# mediante el motor Instant Generator, se verifica la correspondencia modelo–código y se demuestra el cierre del ciclo (roundtrip).

## Estructura del repositorio

| Carpeta | Contenido |
|---|---|
| `docs/` | Informe en LaTeX (`informe.tex`), PDF compilado (`informe.pdf`), referencias (`referencias.bib`) y figuras |
| `modelo/` | Proyecto nativo de Visual Paradigm (`.vpp`): diagrama de clases y perfil |
| `plantillas/` | Plantillas Apache Velocity (`.vm`) y configuración del generador |
| `generado/` | Código C# generado y solución de Visual Studio |
| `evidencias/` | Capturas del proceso completo |
| `exposicion/` | Diapositivas de la exposición |
| `borradores/` | Aportes individuales por integrante |

## Requisitos previos

| Componente | Versión probada | Uso |
|---|---|---|
| Visual Paradigm | 17.3 o superior | Modelado UML y generación de código (Instant Generator) |
| .NET SDK | 6.0 o superior | Compilar y ejecutar el código C# generado |
| Visual Studio 2022 | 17.x (o VS Code + C# Dev Kit) | Abrir la solución generada |
| Distribución LaTeX | TeX Live 2023+ o MiKTeX | Compilar el documento evidencia |
| Biber | 2.19+ (incluido en TeX Live/MiKTeX) | Procesar la bibliografía |

**Sistema operativo probado:** Windows 10/11 (64 bits).

## Cómo compilar el informe (LaTeX → PDF)

- **Archivo principal:** `docs/informe.tex`
- **Compilador:** `pdflatex` (motor pdfTeX)
- **Motor de bibliografía:** `biber` + `biblatex` (estilo IEEE)
- **Salida:** `docs/informe.pdf`

Desde la carpeta `docs/`, ejecutar en este orden exacto (4 pasadas):

```bash
cd docs
pdflatex informe.tex     # 1ª pasada: genera .aux con citas y referencias
biber informe            # procesa referencias.bib -> informe.bbl
pdflatex informe.tex     # 2ª pasada: incorpora la bibliografía
pdflatex informe.tex     # 3ª pasada: resuelve refs cruzadas, ToC, figuras y listados
```

### Dependencias LaTeX

La clase base es `IEEEtran` (formato IEEE, una columna). Paquetes requeridos (todos incluidos en una instalación completa de TeX Live o MiKTeX):

```
IEEEtran, inputenc, fontenc, babel (español), csquotes, hyphenat,
booktabs, tabularx, array, multirow, longtable, graphicx, float,
xcolor, listings, geometry, fancyhdr, parskip, enumitem, amssymb,
titlesec, caption, biblatex (backend biber), hyperref
```

Si usas **MiKTeX**, acepta la instalación automática de paquetes al primer llamado. En **TeX Live**, `scheme-full` los cubre todos.

### Alternativa: compilar en Overleaf

1. Subir `informe.tex`, `referencias.bib` y la carpeta `figuras/` a un proyecto nuevo.
2. En *Menu → Settings*, fijar **Compiler: pdfLaTeX** y **TeX Live version 2023 o superior**.
3. Overleaf ejecuta automáticamente las pasadas de `pdflatex` + `biber`; basta con pulsar *Recompile*.

## Cómo reproducir la generación de código (UML → C#)

1. Abrir `modelo/MundiPets-DiagramaClases.vpp` en Visual Paradigm 17.3 o superior.
2. Ir a `Tools → Code → Instant Generator`, seleccionar lenguaje **C#**.
3. Marcar las 8 clases y las 2 enumeraciones; establecer como salida la carpeta `generado/`.
4. (Opcional) Pulsar *Preview* para verificar la salida antes de escribir los archivos.
5. Ejecutar `Generate`.
6. Abrir la solución en `generado/MundiPets_Evidencia_CodigoGeneradoVPP/` con Visual Studio 2022 para compilar y ejecutar la unidad demostrable.

> Las plantillas Apache Velocity (`.vm`) usadas por el generador y la captura de la configuración están en `plantillas/`.

## Video de la demostración

Disponible en YouTube: https://youtu.be/MVsjU1ElENk

## Créditos y responsabilidades

- **Fuertes Arraes Edson Daniel** — titular del PFC MundiPets; modelado UML, perfil, configuración y ejecución del generador, verificación, roundtrip e integración/compilación del documento LaTeX.
- **Cedeño Avila Winston Damian** — marco teórico, descripción del subsistema y conclusiones.
- **Cedeño Coronado Wilson Lizandro** — justificación de la herramienta MDD y comparación con la alternativa descartada.

La evidencia objetiva del reparto está en el historial de *commits* (identidad Git propia por integrante) y en `Insights → Contributors` del repositorio.
