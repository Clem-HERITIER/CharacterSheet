# Étape 1  build (compilation du projet)
FROM mcr.microsoft.comdotnetsdk8.0 AS build
WORKDIR src

# Copie les fichiers de projet
COPY .sln .
COPY Wfrp.API.csproj Wfrp.API
COPY Wfrp.Application.csproj Wfrp.Application
COPY Wfrp.Domain.csproj Wfrp.Domain
COPY Wfrp.Infrastructure.csproj Wfrp.Infrastructure
COPY Wfrp.Shared.csproj Wfrp.Shared

# Restore des packages NuGet
RUN dotnet restore

# Copie tout le code source
COPY . .

# Va dans le projet principal et compile
WORKDIR srcWfrp.API
RUN dotnet publish -c Release -o apppublish

# Étape 2  runtime (image plus légère sans SDK)
FROM mcr.microsoft.comdotnetaspnet8.0
WORKDIR app
COPY --from=build apppublish .     # On copie le code compilé
ENTRYPOINT [dotnet, Wfrp.API.dll] # Commande lancée quand le conteneur démarre