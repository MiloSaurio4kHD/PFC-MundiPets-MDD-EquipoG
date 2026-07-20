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
| `docs/` | Informe en LaTeX (`informe.tex`), PDF compilado, referencias y figuras |
| `modelo/` | Proyecto nativo de Visual Paradigm (`.vpp`): diagrama de clases y perfil |
| `plantillas/` | Plantillas Apache Velocity (`.vm`) y configuración del generador |
| `generado/` | Código C# generado y solución de Visual Studio |
| `evidencias/` | Capturas del proceso completo |
| `exposicion/` | Diapositivas de la exposición |
| `borradores/` | Aportes individuales por integrante |

## Herramientas utilizadas

- **Visual Paradigm 17.3** — modelado UML y generación de código (Instant Generator)
- **C#** — lenguaje objetivo
- **Visual Studio 2022** — compilación y ejecución del código generado
- **LaTeX** (IEEEtran + biblatex/biber) — documento evidencia

## Cómo compilar el informe

En la carpeta `docs/`, ejecutar en orden:

```bash
pdflatex informe.tex
biber informe
pdflatex informe.tex
pdflatex informe.tex
```

Requiere una distribución LaTeX con los paquetes `IEEEtran`, `biblatex`, `listings` y `babel` (español).

## Cómo reproducir la generación de código

1. Abrir `modelo/MundiPets-DiagramaClases.vpp` en Visual Paradigm 17.3 o superior.
2. Ir a `Tools → Code → Instant Generator`, seleccionar lenguaje **C#**.
3. Marcar las 8 clases y las 2 enumeraciones; establecer como salida la carpeta `generado/`.
4. Ejecutar `Generate`.
5. Abrir la solución en `generado/MundiPets_Evidencia_CodigoGeneradoVPP/` con Visual Studio 2022 para compilar y ejecutar.

## Video de la demostración

Disponible en YouTube: https://youtu.be/MVsjU1ElENk
