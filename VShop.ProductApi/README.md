# Configura��es

## Controllers: Endpoint

| Verbo HTTP | EndPoint | Status Code | Descri��o |
| --- | --- | --- | --- |
| POST | /categories | 201 Created | Cria uma categoria |
| GET | /categories/{id:int} | 200 OK, 404 Not Found | Obt�m uma categoria pelo Id |
| GET | /categories | 200 OK | Obt�m todas as categorias |
| GET | /categories/products | 200 OK | Obt�m todas as categorias e produtos |
| PUT | /categories/{id:int} | 200 OK, 404 Not Found, 400 Bad Request | Atualiza uma categoria pelo seu id |
| DELETE | /categories/{id:int} | 204 No Content|Deleta uma categoria pelo seu id |



| Verbo HTTP | EndPoint | Status Code | Descri��o |
| --- | --- | --- | --- |
| POST | /products | 201 Created | Cria uma categoria |
| GET | /products/{id:int} | 200 OK, 404 Not Found | Obt�m uma categoria pelo Id |
| GET | /products | 200 OK | Obt�m todas as categorias |
| PUT | /products/{id:int} | 200 OK, 404 Not Found, 400 Bad Request | Atualiza uma categoria pelo seu id |
| DELETE | /products/{id:int} | 204 No Content|Deleta uma categoria pelo seu id |