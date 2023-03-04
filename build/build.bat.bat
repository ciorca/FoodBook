cd ../src/FoodBook.Api

dotnet restore
dotnet build --no-restore
dotnet publish -o ../../deploy