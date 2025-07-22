# 🍽️ Restaurant Manager API

API RESTful para la gestión de restaurantes. Permite a los usuarios registrarse, iniciar sesión, administrar sus propios restaurantes y platos, todo con un sistema de roles bien definido. Diseñada para ser **simple, segura y extensible**.

---

## 🚀 Tecnologías utilizadas

- 🟢 .net/C#
- 🗄️ Base de datos (SQL Server)
- 🔐 Autenticación con JWT
- 🛡️ Autorización basada en roles

---

## 🔧 Características principales

### 🔐 Autenticación & Autorización
- ✅ Registro e inicio de sesión de usuarios
- 👤 Identidad persistente con tokens JWT
- 🔐 Autorización por **roles**:
  - 👑 **Administrador:** acceso total al sistema (usuarios, restaurantes, etc.)
  - 🧑‍🍳 **Propietario:** puede crear y administrar sus propios restaurantes y platos

### 🧩 Gestión de Recursos

#### 📍 Restaurantes
- 🔄 CRUD completo (Crear, Leer, Actualizar, Eliminar)
- Asociados directamente al usuario propietario

#### 🍽️ Platos
- 📌 CRUD de platos por restaurante
- Cada plato está ligado a un restaurante específico

### 🛡️ Seguridad y permisos
- 🔏 Los usuarios solo pueden modificar sus propios recursos
- 🔐 Los administradores pueden ver y gestionar todo

