# Chemin du fichier source à lire
$sourcePath = "C:\Users\cleme\source\repos\CharacterSheet\Input.txt"

# Chemin du fichier de sortie
$outputPath = "C:\Users\cleme\source\repos\CharacterSheet\Result.txt"

# Lecture du fichier en texte brut
$content = Get-Content -Raw -Path $sourcePath

# Nettoyage
$processed = ($content -replace '([^\.\r\n])\r?\n\s*', '$1 ' `
                     -replace '^\s+', '' `
                     -replace '\s+$', '')

# Sauvegarde du texte nettoyé
Set-Content -Path $outputPath -Value $processed -NoNewline

Write-Host "✅ Fichier nettoyé enregistré dans : $outputPath"