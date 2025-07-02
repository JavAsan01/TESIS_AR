# Git LFS Setup para Proyectos Unity con Archivos Pesados

## 🚨 Problema Identificado

Al intentar subir este proyecto Unity a GitHub, se encontraron varios archivos que exceden los límites de GitHub:

```
❌ Error original:
remote: error: File Packages/com.ptc.vuforia.engine-10.16.5.tgz is 133.61 MB; 
    this exceeds GitHub's file size limit of 100.00 MB
remote: error: File Assets/Resources/AR+CESIUM/com.cesium.unity-1.6.1.tgz is 177.43 MB; 
    this exceeds GitHub's file size limit of 100.00 MB
remote: warning: File Assets/TextMesh Pro/Fonts/Chino/Noto_Sans_TC.zip is 72.33 MB; 
    this is larger than GitHub's recommended maximum file size of 50.00 MB
```

## 📋 Límites de GitHub

| Tipo de archivo | Límite | Acción requerida |
|-----------------|--------|------------------|
| **Archivo normal** | 100 MB (límite estricto) | Git LFS obligatorio |
| **Archivo grande** | 50 MB (advertencia) | Git LFS recomendado |
| **Repositorio total** | 1 GB recomendado | Optimización general |

## 🔧 Solución Implementada: Git LFS

### 1. Verificación de Git LFS

```powershell
# Verificar si Git LFS está instalado
git lfs --version
# Output esperado: git-lfs/3.5.1 (GitHub; windows amd64; go 1.21.7; git e237bb3a)
```

### 2. Configuración de Git LFS

```powershell
# Configurar tracking para archivos .tgz (packages Unity)
git lfs track "*.tgz"

# Configurar tracking para archivos .zip grandes
git lfs track "*.zip"

# Añadir el archivo de configuración
git add .gitattributes
```

**Archivo `.gitattributes` generado:**
```
*.tgz filter=lfs diff=lfs merge=lfs -text
*.zip filter=lfs diff=lfs merge=lfs -text
```

### 3. Migración del Historial Existente

Como los archivos grandes ya estaban en el historial de commits, fue necesario migrar el historial:

```powershell
# Migrar historial existente para usar LFS
git lfs migrate import --include="*.tgz,*.zip"

# Verificar archivos migrados
git lfs ls-files
```

### 4. Proceso de Commit y Push

```powershell
# Reset del commit anterior (si es necesario)
git reset --soft HEAD~1

# Añadir todos los archivos (LFS manejará los grandes automáticamente)
git add -A

# Commit con mensaje descriptivo
git commit -m "feat: Add complete TESIS_AR project with README and LFS support"

# Push forzado debido a la reescritura del historial
git push origin main --force-with-lease
```

## 📊 Archivos Migrados a LFS

Los siguientes archivos fueron migrados exitosamente a Git LFS:

| Archivo | Tamaño | Tipo | Descripción |
|---------|--------|------|-------------|
| `Packages/com.ptc.vuforia.engine-10.16.5.tgz` | 133.61 MB | Package | Vuforia Engine SDK |
| `Assets/Resources/AR+CESIUM/com.cesium.unity-1.6.1.tgz` | 177.43 MB | Package | Cesium for Unity |
| `Assets/Resources/AR+CESIUM/arcore-unity-extensions-1.39.0.tgz` | ~100 MB | Package | ARCore Extensions |
| `Assets/TextMesh Pro/Fonts/Chino/Noto_Sans_TC.zip` | 72.33 MB | Font | Fuente China para TextMeshPro |

**Total archivos LFS:** 4 archivos, ~405 MB

## ✅ Resultado Final

```powershell
PS C:\GitHub\TESIS_AR> git push origin main --force-with-lease
Uploading LFS objects: 100% (4/4), 405 MB | 11 MB/s, done.
Enumerating objects: 2563, done.
Counting objects: 100% (2563/2563), done.
Delta compression using up to 8 threads
Compressing objects: 100% (2559/2559), done.
Writing objects: 100% (2563/2563), 407.19 MiB | 7.66 MiB/s, done.
Total 2563 (delta 1447), reused 1 (delta 0), pack-reused 0 (from 0)
remote: Resolving deltas: 100% (1447/1447), done.
To https://github.com/JavAsan01/TESIS_AR.git
 + d4ccc94...9796953 main -> main (forced update)
```

## 🎯 Beneficios de Git LFS

### Para el Repositorio
- ✅ **Clones más rápidos**: Los archivos grandes se descargan solo cuando se necesitan
- ✅ **Historial limpio**: Git no necesita almacenar múltiples versiones de archivos binarios grandes
- ✅ **Mejor rendimiento**: Operaciones Git más rápidas

### Para el Proyecto Unity
- ✅ **Packages preservados**: Vuforia, Cesium y ARCore Extensions intactos
- ✅ **Assets multimedia**: Fuentes, texturas y recursos preservados
- ✅ **Compatibilidad**: Funciona seamlessly con Unity Package Manager

## 📋 Comandos de Referencia Rápida

### Configuración Inicial
```powershell
# Instalar Git LFS (si no está instalado)
git lfs install

# Configurar tracking por tipo de archivo
git lfs track "*.tgz"
git lfs track "*.zip"
git lfs track "*.unitypackage"
git lfs track "*.fbx"
git lfs track "*.psd"

# Commit configuración
git add .gitattributes
git commit -m "Configure Git LFS for Unity assets"
```

### Verificación
```powershell
# Ver archivos rastreados por LFS
git lfs ls-files

# Ver configuración de tracking
git lfs track

# Verificar estado de LFS
git lfs status
```

### Solución de Problemas
```powershell
# Si hay archivos grandes ya commitados
git lfs migrate import --include="*.tgz,*.zip" --everything

# Verificar integridad
git lfs fsck

# Re-push forzado (CUIDADO: solo si es necesario)
git push origin main --force-with-lease
```

## ⚠️ Consideraciones Importantes

### 1. **Costo de Almacenamiento**
- GitHub LFS tiene límites de ancho de banda mensual
- Plan gratuito: 1 GB storage, 1 GB bandwidth/mes
- Planes pagos disponibles para proyectos grandes

### 2. **Colaboración en Equipo**
```powershell
# Los colaboradores deben tener Git LFS instalado
git lfs install

# Primer clone con LFS
git clone <repo-url>
cd <repo-name>
git lfs pull  # Descargar archivos LFS
```

### 3. **CI/CD Considerations**
- Asegurar que runners tengan Git LFS instalado
- Configurar credenciales para acceso a LFS
- Considerar tiempo adicional para download de assets

## 🔗 Referencias

- [Git LFS Official Documentation](https://git-lfs.github.io/)
- [GitHub LFS Documentation](https://docs.github.com/en/repositories/working-with-files/managing-large-files)
- [Unity Version Control Best Practices](https://docs.unity3d.com/Manual/ExternalVersionControlSystemRequirements.html)

## 📝 Notas del Proyecto

Este setup fue implementado específicamente para el proyecto **LATOUR**, una aplicación AR para el Parque Nacional Cotopaxi desarrollada como tesis universitaria en 2024.

**Archivos críticos para el proyecto:**
- **Vuforia Engine**: Tracking de imágenes AR
- **Cesium Unity**: Renderizado geoespacial 3D
- **ARCore Extensions**: Geolocalización AR precisa
- **TextMeshPro Fonts**: Soporte multiidioma (ES, EN, FR, DE, IT)

---

*Documentado el 7 de febrero de 2025*  
*Proyecto: TESIS_AR - LATOUR*  
*Desarrollador: javasan.dev@gmail.com*
