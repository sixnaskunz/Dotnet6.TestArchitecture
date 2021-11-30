#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Dotnet6.TestArchitecture/Dotnet6.TestArchitecture.csproj", "Dotnet6.TestArchitecture/"]
RUN dotnet restore "Dotnet6.TestArchitecture/Dotnet6.TestArchitecture.csproj"
COPY . .
WORKDIR "/src/Dotnet6.TestArchitecture"
RUN dotnet build "Dotnet6.TestArchitecture.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dotnet6.TestArchitecture.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dotnet6.TestArchitecture.dll"]