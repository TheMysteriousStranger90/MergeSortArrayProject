FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MergeSortArrayProject/MergeSortArrayProject.csproj", "MergeSortArrayProject/"]
RUN dotnet restore "MergeSortArrayProject/MergeSortArrayProject.csproj"
COPY . .
WORKDIR "/src/MergeSortArrayProject"
RUN dotnet build "MergeSortArrayProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MergeSortArrayProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MergeSortArrayProject.dll"]
