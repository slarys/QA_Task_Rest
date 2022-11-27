FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["QA_Task/QA_Task.csproj", "QA_Task/"]
RUN dotnet restore "QA_Task/QA_Task.csproj"
COPY . .
WORKDIR "/src/QA_Task"
RUN dotnet build "QA_Task.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QA_Task.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QA_Task.dll"]
