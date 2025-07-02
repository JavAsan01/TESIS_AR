# APP MOVIL LATOUR
## Aplicación de Realidad Aumentada para el Parque Nacional Cotopaxi

![Unity](https://img.shields.io/badge/Unity-2022.3.6f1-black?logo=unity)
![AR Foundation](https://img.shields.io/badge/AR_Foundation-5.0.7-blue)
![Platform](https://img.shields.io/badge/Platform-Android%20%7C%20iOS-green)
![License](https://img.shields.io/badge/License-Academic-orange)

Una aplicación de Realidad Aumentada (AR) desarrollada como proyecto de tesis universitaria en 2024 para potenciar el turismo en el **Parque Nacional Cotopaxi**, Ecuador. Esta app está diseñada para ofrecer experiencias inmersivas a los visitantes del parque, con planes futuros de expansión a Realidad Virtual (VR).

---

## 📋 Tabla de Contenidos

- [Descripción del Proyecto](#-descripción-del-proyecto)
- [Características Principales](#-características-principales)
- [Tecnologías Utilizadas](#️-tecnologías-utilizadas)
- [Estructura del Proyecto](#-estructura-del-proyecto)
- [Configuración e Instalación](#️-configuración-e-instalación)
- [Escenas del Proyecto](#-escenas-del-proyecto)
- [Sistema de Localización](#-sistema-de-localización)
- [APIs y Servicios](#-apis-y-servicios)
- [Recursos Multimedia](#-recursos-multimedia)
- [Control de Versiones](#-control-de-versiones)
- [Uso de la Aplicación](#-uso-de-la-aplicación)
- [Especificaciones Técnicas](#-especificaciones-técnicas)
- [Contribución](#-contribución)
- [Licencia](#-licencia)
- [Contacto](#-contacto)

---

## 🎯 Descripción del Proyecto

**LATOUR** es una aplicación móvil de Realidad Aumentada diseñada específicamente para el Parque Nacional Cotopaxi en la provincia de Cotopaxi, Ecuador. La aplicación busca:

- **Enriquecer la experiencia turística** mediante contenido AR interactivo
- **Proporcionar información educativa** sobre la flora, fauna e historia del parque
- **Ofrecer guías digitales** con mapas y rutas interactivas
- **Promover el turismo sostenible** y responsable en Ecuador

### Contexto del Parque Nacional Cotopaxi

El Parque Nacional Cotopaxi es un destino emblemático en Ecuador, reconocido por:
- Su belleza natural y diversidad biológica
- El volcán Cotopaxi (5,897 metros de altitud)
- Ecosistemas únicos de páramo andino
- Fauna endémica como el cóndor andino y oso de anteojos
- Historia cultural de pueblos indígenas prehispánicos

---

## ✨ Características Principales

### 🔮 Realidad Aumentada
- **Detección de planos**: Permite colocar objetos 3D en superficies reales
- **Geolocalización AR**: Utiliza GPS y ARCore Geospatial API para experiencias basadas en ubicación
- **Modelos 3D interactivos**: Representaciones de fauna local (cóndor andino, oso de anteojos, venado de cola blanca)
- **Portal AR**: Experiencias inmersivas de teletransporte virtual al parque

### 📚 Sistema de Información
- **Guía multiidioma**: Soporte para español, inglés, francés, alemán e italiano
- **Contenido educativo**: Información detallada sobre el volcán Cotopaxi, historia y ecosistema
- **Mapas interactivos**: Rutas y senderos del parque nacional
- **Museo virtual**: Exhibiciones digitales sobre el parque

### 🎮 Funcionalidades Adicionales
- **Detección de imágenes**: Reconocimiento de marcadores específicos con Vuforia
- **Interfaz adaptativa**: Diseño responsive para diferentes dispositivos
- **Navegación intuitiva**: UX optimizada para uso en exteriores

---

## 🛠️ Tecnologías Utilizadas

### Unity y AR
- **Unity 2022.3.6f1**: Motor de desarrollo principal
- **AR Foundation 5.0.7**: Framework de AR multiplataforma
- **ARCore 5.0.7** (Android): Soporte para dispositivos Android
- **ARKit 5.0.6** (iOS): Soporte para dispositivos iOS

### Servicios de Google
- **Google Maps Platform**: Integración con mapas y geolocalización
- **ARCore Geospatial Extensions 1.39.0**: Funcionalidades avanzadas de geolocalización
- **Google Earth data**: Para anclaje preciso de contenido AR

### Otros Frameworks
- **Vuforia Engine 10.16.5**: Sistema de AR para tracking de imágenes
- **Cesium for Unity 1.6.1**: Renderizado de datos geoespaciales 3D
- **Unity Localization 1.4.5**: Sistema de traducción multiidioma
- **DOTween**: Animaciones fluidas

---

## 📁 Estructura del Proyecto

```
Assets/
├── Scenes/                          # Escenas principales de la aplicación
│   ├── SampleScene.unity           # Escena principal/menú
│   ├── Geospatial.unity           # AR con geolocalización
│   ├── PlaneDetection.unity       # Detección de planos AR
│   ├── Portal.unity               # Experiencia de portal AR
│   └── Informacion.unity          # Pantalla de información
├── Localization/                   # Sistema de idiomas
│   ├── Guia_Dic/                  # Diccionarios de la guía turística
│   │   ├── Guia_Dic_es.asset     # Español (idioma principal)
│   │   ├── Guia_Dic_en.asset     # Inglés
│   │   ├── Guia_Dic_fr.asset     # Francés
│   │   ├── Guia_Dic_de.asset     # Alemán
│   │   └── Guia_Dic_it.asset     # Italiano
│   └── Plane_Detection/           # Textos para detección de planos
├── Resources/                      # Recursos multimedia
│   ├── 3D/                       # Modelos 3D de fauna y flora
│   ├── Imagenes/                 # Fotografías del parque
│   ├── Videos/                   # Videos del volcán Cotopaxi
│   ├── Audios/                   # Sonidos ambientales
│   ├── Portal 360/               # Contenido para portal VR/AR
│   └── AR+CESIUM/                # Archivos de integración AR/Cesium
├── GoogleMaps/                     # Integración con Google Maps
├── Samples/                        # Ejemplos de ARCore Extensions
│   └── ARCore Extensions/
│       └── 1.39.0/
│           └── Geospatial Sample/  # Implementación geoespacial
├── Scripts/                        # Scripts de Unity
├── Materials/                      # Materiales y shaders
├── Plugins/                        # Plugins externos
│   ├── NativeShare/               # Plugin para compartir contenido
│   └── Demigiant/                 # DOTween para animaciones
└── StreamingAssets/               # Assets para streaming
```

### Escenas Detalladas

#### `SampleScene.unity`
- **Propósito**: Menú principal y navegación de la aplicación
- **Funcionalidad**: Punto de entrada para acceder a todas las características

#### `Geospatial.unity`
- **Propósito**: Experiencias AR basadas en geolocalización
- **Tecnología**: Google ARCore Geospatial API
- **Funcionalidad**: Coloca contenido AR en ubicaciones específicas del mundo real

#### `PlaneDetection.unity`
- **Propósito**: Detección de superficies para colocación de objetos 3D
- **Funcionalidad**: Permite a los usuarios colocar modelos de fauna en superficies detectadas

#### `Portal.unity`
- **Propósito**: Experiencia inmersiva de portal AR
- **Funcionalidad**: Crea "ventanas" virtuales a diferentes ubicaciones del parque

#### `Informacion.unity`
- **Propósito**: Centro de información del parque
- **Contenido**: Guías, mapas, historia y regulaciones del parque

---

## ⚙️ Configuración e Instalación

### Prerrequisitos
- **Unity 2022.3.6f1** o superior
- **Android SDK** (para builds de Android)
- **Xcode** (para builds de iOS)
- **Dispositivo móvil** compatible con ARCore/ARKit

### Pasos de Instalación

1. **Clonar el repositorio**
   ```bash
   # Si tienes acceso al repositorio original
   git clone [URL_DEL_REPOSITORIO]
   cd TESIS_AR
   ```

2. **Abrir en Unity**
   - Abrir Unity Hub
   - Seleccionar "Open Project"
   - Navegar a la carpeta del proyecto

3. **Configurar APIs de Google**
   - Obtener API key de Google Maps Platform
   - Configurar ARCore/ARKit según la plataforma objetivo
   - Verificar configuración de Vuforia Engine

4. **Configurar Build Settings**
   - Android: API Level 24+, ARCore compatible
   - iOS: iOS 11+, ARKit compatible
   - Asegurar que todas las escenas estén incluidas en el build

### Configuración de Packages

Los siguientes packages están incluidos:
```json
{
  "com.cesium.unity": "file:../Assets/Resources/AR+CESIUM/com.cesium.unity-1.6.1.tgz",
  "com.google.ar.core.arfoundation.extensions": "file:../Assets/Resources/AR+CESIUM/arcore-unity-extensions-1.39.0.tgz",
  "com.ptc.vuforia.engine": "file:com.ptc.vuforia.engine-10.16.5.tgz",
  "com.unity.xr.arfoundation": "5.0.7",
  "com.unity.xr.arcore": "5.0.7",
  "com.unity.localization": "1.4.5"
}
```

---

## 🎬 Escenas del Proyecto

### Flujo de Navegación
```
SampleScene (Menú Principal)
    ├── Informacion → Información del parque
    ├── PlaneDetection → AR con detección de planos
    ├── Geospatial → AR con geolocalización
    └── Portal → Experiencia de portal inmersivo
```

### Funcionalidades por Escena

| Escena | Funcionalidad Principal | Tecnología AR |
|--------|-------------------------|---------------|
| **SampleScene** | Navegación y menú | - |
| **Informacion** | Guía turística multiidioma | UI localizada |
| **PlaneDetection** | Colocación de fauna 3D | AR Foundation |
| **Geospatial** | Contenido basado en ubicación | ARCore Geospatial |
| **Portal** | Experiencia inmersiva 360° | Portal AR |

---

## 🌍 Sistema de Localización

La aplicación soporta múltiples idiomas mediante Unity Localization Package:

### Idiomas Soportados
- **🇪🇸 Español** - Idioma principal
- **🇺🇸 Inglés** - English
- **🇫🇷 Francés** - Français
- **🇩🇪 Alemán** - Deutsch
- **🇮🇹 Italiano** - Italiano

### Contenido Localizado
- **Historia del volcán Cotopaxi** y erupciones significativas
- **Descripciones de flora y fauna** endémica
- **Guías de rutas y senderos** del parque
- **Regulaciones y normas** del área protegida
- **Interfaces de usuario** completamente traducidas

### Información Cultural
- **Significado de "Cotopaxi"**: Proviene del kichwa "cutu" (cuello) y "paxi" (luna)
- **Historia indígena**: Pueblos Puruháes, Panzaleos y Cañaris
- **Patrimonio cultural**: Considerado sagrado por civilizaciones precolombinas

---

## 📱 APIs y Servicios

### Google Services Integration

#### Google Maps Platform
```cs
// Funcionalidades integradas
- Mapas interactivos del Parque Nacional Cotopaxi
- Navegación GPS para rutas de senderismo
- Puntos de interés geolocalizados
- Integración con datos de Google Earth
```

**Servicios utilizados:**
- **Maps SDK**: Visualización de mapas interactivos
- **Geolocation API**: Determinación de ubicación del usuario
- **Places API**: Información sobre puntos de interés

#### ARCore Geospatial API
```cs
// Características principales
- Precisión submétrica en ubicaciones con buena cobertura
- Cobertura del Parque Nacional Cotopaxi y áreas circundantes
- Anclaje de contenido AR a coordenadas del mundo real
- Cloud Anchors para experiencias compartidas
```

**Implementación:**
- **Earth Manager**: Gestión del estado de geolocalización
- **Geospatial Anchors**: Anclaje persistente de objetos AR
- **Terrain Anchors**: Anclaje al terreno real

### Vuforia Engine Integration
```cs
// Configuración actual
- Versión: 10.16.5
- Tracking de imágenes: Activado
- AR Foundation: Compatible (5.0.7)
- Plataformas: Android/iOS
```

---

## 🎨 Recursos Multimedia

### Contenido Visual Auténtico

El proyecto incluye recursos multimedia auténticos del Parque Nacional Cotopaxi:

#### `Assets/Resources/`

**📁 3D/** - Modelos tridimensionales
- **Fauna**: Cóndor andino, oso de anteojos, venado de cola blanca
- **Flora**: Vegetación de páramo, frailejones
- **Geología**: Formaciones volcánicas

**📁 Imagenes/** - Fotografías originales
- Imágenes capturadas durante visitas de campo al parque
- Paisajes del volcán Cotopaxi
- Flora y fauna in situ
- Laguna de Limpiopungo

**📁 Videos/** - Material audiovisual
- Grabaciones del volcán Cotopaxi
- Paisajes del páramo andino
- Time-lapse de formaciones de nubes

**📁 Audios/** - Sonidos ambientales
- Ambiente natural del páramo
- Sonidos de fauna local
- Efectos de viento en altura

**📁 Portal 360/** - Contenido inmersivo
- Panoramas 360° del parque
- Experiencias de realidad virtual
- Tours virtuales

### Contenido Educativo

#### Historia y Geología
- **Formación volcánica**: Estratovolcán de 5,897 metros
- **Erupciones históricas**: 1877 (más devastadora), 1904
- **Actividad actual**: Monitoreo sísmico continuo

#### Biodiversidad
- **Ecosistema de páramo**: Entre 3,400-4,600 msnm
- **Especies endémicas**: Adaptadas a condiciones extremas
- **Conservación**: Área protegida desde 1975

#### Información Práctica
- **Rutas de senderismo**: Diferentes niveles de dificultad
- **Equipamiento necesario**: Ropa térmica, protección UV
- **Normativas**: Regulaciones del área protegida

---

## 📊 Control de Versiones

### Unity DevOps Version Control

Este proyecto utiliza **Unity DevOps Version Control** (anteriormente Unity Collaborate):

```
📈 Historial del Proyecto:
├── Último Commit: 11/3/2024 15:02:48
├── Autor: carlossasanza15072001@gmail.com
├── Changeset: 61 (ba250015)
└── Estado: LATOUR DEFENSA v2.0
```

### Guidelines para Desarrollo
1. **Convenciones de nomenclatura** de Unity
2. **Documentar cambios** en scripts principales
3. **Probar en dispositivos físicos** antes de commits
4. **Mantener compatibilidad** con versiones de AR Foundation

### Estructura de Branches
- **main**: Versión estable para presentación
- **development**: Desarrollo activo de características
- **feature/***: Ramas para características específicas

---

## 🚀 Uso de la Aplicación

### Para Desarrolladores

#### Configuración del Entorno
```bash
# 1. Verificar Unity Version
Unity 2022.3.6f1 o superior

# 2. Instalar Android/iOS SDKs
Android SDK API Level 24+
Xcode 12+ (para iOS)

# 3. Configurar APIs
Google Maps API Key
ARCore/ARKit habilitado
```

#### Testing y Debug
```cs
// Modo Debug disponible en build de desarrollo
DebugText.text = $"EarthState: {EarthManager.EarthState}";
// Tracking de geolocalización en tiempo real
// Logs de rendimiento AR
```

### Para Usuarios Finales

#### Instalación
1. **Android**: Instalar APK desde archivo
2. **iOS**: Instalar IPA a través de TestFlight
3. **Permisos**: Otorgar acceso a cámara y ubicación

#### Uso en el Parque
```
📍 Ubicación óptima: Parque Nacional Cotopaxi
🌐 Conectividad: GPS + Internet (para mapas)
📱 Calibración: Seguir instrucciones de calibración AR
🎯 Exploración: Usar todas las funciones in-situ
```

#### Flujo de Usuario
1. **Pantalla de bienvenida** con selección de idioma
2. **Información del parque** con guías interactivas
3. **Experiencias AR** contextuales
4. **Navegación por mapas** interactivos

---

## 📊 Especificaciones Técnicas

### Rendimiento Recomendado

| Componente | Mínimo | Recomendado |
|------------|---------|-------------|
| **RAM** | 4GB | 6GB+ |
| **Almacenamiento** | 2GB libre | 3GB+ |
| **Procesador** | Snapdragon 660+ / A12+ | Snapdragon 855+ / A14+ |
| **Conectividad** | GPS + 3G | GPS + 4G/WiFi |

### Compatibilidad AR

#### Android (ARCore)
```
📋 Dispositivos compatibles:
- Samsung Galaxy S8+
- Google Pixel series
- OnePlus 6+
- Huawei P20+
- Lista completa: developers.google.com/ar/devices
```

#### iOS (ARKit)
```
📋 Dispositivos compatibles:
- iPhone 6S y posteriores
- iPad (5th generation) y posteriores
- iPad Pro (todos los modelos)
- iOS 11.0+
```

### Optimización

#### Configuración de Calidad
```cs
// Settings optimizados para AR
Application.targetFrameRate = 60;
QualitySettings.vSyncCount = 0;
```

#### Memory Management
```cs
// Gestión eficiente de recursos 3D
- Texture compression optimizada
- Mesh optimization para modelos
- Audio compression para sonidos ambientales
```

---

## 🤝 Contribución

### Información del Proyecto

Este proyecto fue desarrollado como **proyecto de tesis universitaria** en 2024 para promover el turismo sostenible en Ecuador.

#### Desarrollo Académico
- **Propósito**: Tesis de grado universitario
- **Enfoque**: Turismo tecnológico y conservación
- **Metodología**: Investigación aplicada con implementación práctica

#### Colaboración Futura
Para contribuciones o mejoras:

1. **Fork del proyecto** (cuando esté disponible públicamente)
2. **Crear feature branch**: `git checkout -b feature/nueva-caracteristica`
3. **Commit cambios**: `git commit -m 'Agregar nueva característica'`
4. **Push branch**: `git push origin feature/nueva-caracteristica`
5. **Crear Pull Request**

#### Áreas de Mejora Identificadas
- **Expansión a RV**: Implementación completa de realidad virtual
- **Más contenido 3D**: Modelos adicionales de flora y fauna
- **Gamificación**: Elementos de juego para aumentar engagement
- **Accesibilidad**: Mejoras para usuarios con discapacidades

---

## 📄 Licencia

### Uso Académico

Este proyecto fue desarrollado con **fines académicos** para una tesis universitaria. 

#### Restricciones de Uso
- **Uso educativo**: Permitido con atribución
- **Uso comercial**: Requiere autorización del desarrollador
- **Distribución**: Contactar para términos específicos

#### Assets de Terceros
- **Unity**: Licencia Personal/Student
- **Google APIs**: Sujeto a términos de Google Cloud Platform
- **Vuforia**: Licencia de desarrollo
- **ARCore/ARKit**: Licencias de Google/Apple respectivamente

---

## 📞 Contacto

### Desarrolladores
**Nombres**: Carlos Javier Asanza Orozco y Walter Santiago Loachamin Changoluisa

**Email Dev1**: javasan.dev@gmail.com 

**Proyecto**: Tesis - Aplicación AR para Turismo en Parque Nacional Cotopaxi  
**Año**: 2024  

### Información Institucional
- **Nivel**: Proyecto de Tesis Universitaria
- **Área**: Ingeniería en Sistemas de Información
- **Enfoque**: Turismo Digital y Realidad Aumentada

### Reconocimientos
- **Parque Nacional Cotopaxi**: Por permitir la investigación y captura de material.
- **Ministerio del Ambiente de Ecuador**: Por información oficial del parque.
- **Comunidades locales**: Por compartir conocimiento cultural.

---

## 🎯 Objetivos Cumplidos

### Técnicos ✅
- [x] Implementación de AR Foundation multiplataforma
- [x] Integración con Google Maps y ARCore Geospatial
- [x] Sistema de localización multiidioma
- [x] Interfaz de usuario intuitiva
- [x] Optimización para dispositivos móviles

### Educativos ✅
- [x] Contenido educativo sobre biodiversidad
- [x] Información histórica y cultural
- [x] Guías de turismo responsable
- [x] Material fotográfico y audiovisual auténtico

### Sociales ✅
- [x] Promoción del turismo sostenible
- [x] Valoración del patrimonio natural ecuatoriano
- [x] Accesibilidad multiidioma para turistas internacionales
- [x] Respeto por las comunidades locales

---

## 🔮 Visión Futura

### Roadmap de Expansión
1. **Fase 2**: Implementación completa de VR
2. **Fase 3**: Expansión a otros parques nacionales de Ecuador
3. **Fase 4**: Integración con plataformas de turismo
4. **Fase 5**: Desarrollo de app móvil

### Impacto Esperado
- **Incremento del turismo responsable** en el Parque Nacional Cotopaxi
- **Mejora de la experiencia educativa** de los visitantes
- **Modelo replicable** para otros destinos turísticos de Ecuador
- **Contribución a la conservación** a través de la educación

---

*Desarrollado con ❤️ para promover el turismo sostenible en Ecuador*

**#TurismoDigital #RealidadAumentada #ParqueNacionalCotopaxi #EcuadorPotenciaTurística #TecnologíaParaLaConservación**
