



echo "clean checks"
rm ../Checks/*
echo "Project(s) Cleaned ..."
dotnet clean ../Pagina.sln > ../Checks/clean_Check
cat ../Checks/clean_Check | grep -i "Done Building Project"
echo "Build project(s) ..."
dotnet build ../Pagina.sln > ../Checks/build_check
cat ../Checks/build_check | grep -i \>
echo "Testing project(s)"
dotnet test ../Pagina.sln > ../Checks/test_check
cat ../Checks/test_check | grep -i fail



