FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NFinder.Api/NFinder.Api.csproj", "NFinder.Api/"]
RUN dotnet restore "NFinder.Api/NFinder.Api.csproj"
COPY . .
WORKDIR "/src/NFinder.Api"
RUN dotnet build "NFinder.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NFinder.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NFinder.Api.exe"]
