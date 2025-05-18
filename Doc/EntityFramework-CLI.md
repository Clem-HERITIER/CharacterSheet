# 📌 Dotnet EF CLI Cheatsheet

## 📦 Installation
```bash
dotnet tool install --global dotnet-ef
```

---

## 🏁 Basic Commands

### 🔍 Check installation
```bash
dotnet ef
```

### 🔧 Specify startup or data project
```bash
dotnet ef <command> --startup-project ../MyApp.Api --project ../MyApp.Infrastructure
```

---

## 📄 Migrations

### 🆕 Add a new migration
```bash
dotnet ef migrations add MigrationName
```

### 🗑️ Remove the last migration
```bash
dotnet ef migrations remove
```

### 📋 List all migrations
```bash
dotnet ef migrations list
```

---

## 🗃️ Database

### 📤 Apply migrations to the database
```bash
dotnet ef database update
```

### 📥 Revert to a specific migration
```bash
dotnet ef database update MigrationName
```

### 🧨 Drop the database
```bash
dotnet ef database drop --force --no-build
```

---

## 🧠 Scaffold (Reverse Engineering)

### 🏗️ Generate models from existing database
```bash
dotnet ef dbcontext scaffold "Connection_String" Microsoft.EntityFrameworkCore.SqlServer -o Models
```

Useful options:
- `--context` : set a specific DbContext name
- `--tables` : scaffold only specific tables
- `--schema` : specify schema
- `--no-pluralize` : avoid pluralizing entity names
- `--data-annotations` : use attributes instead of Fluent API

---

## 🔍 Info Commands

### ℹ️ Show DbContext info
```bash
dotnet ef dbcontext info
```

### 📜 Generate SQL script from migrations
```bash
dotnet ef migrations script
```

### 📜 Generate script between two migrations
```bash
dotnet ef migrations script FromMigration ToMigration
```

---

## 💡 Tips

- Use `--verbose` for detailed output.
- Add `--no-build` to skip rebuilding the project:
  ```bash
  dotnet ef database update --no-build
  ```

---

## 🔗 Official Docs

- EF Core CLI: https://learn.microsoft.com/en-us/ef/core/cli/dotnet
