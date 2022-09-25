-- inner join
SELECT U.*, r.* FROM Usuario u INNER JOIN Roles r 
ON u.RolId = r.Id

-- left join
SELECT u.*,R.* FROM Usuario u LEFT JOIN Roles r 
ON u.Usuario_Transaccion = R.Usuario_Transaccion
-- right join
SELECT u.*,R.* FROM Usuario u RIGHT JOIN Roles r 
ON u.Usuario_Transaccion = R.Usuario_Transaccion
-- full join
SELECT u.*,R.* FROM Usuario u FULL JOIN Roles r 
ON u.Usuario_Transaccion = R.Usuario_Transaccion
-- subconsulta
SELECT (select top 1 nombre from Roles where id = u.rolid) rol, u.* FROM Usuario u 