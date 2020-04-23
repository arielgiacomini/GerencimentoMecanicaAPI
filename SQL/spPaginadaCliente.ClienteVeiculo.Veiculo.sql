DECLARE
    @Pagina INT = 5,
    @ItensPorPagina INT = 10

SELECT [name]
FROM sys.objects
ORDER BY [name]
OFFSET (@Pagina - 1) * @ItensPorPagina ROWS
  FETCH NEXT @ItensPorPagina ROWS ONLY