--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
------------------------TABLA-CARRERA-------------------------
--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

create or replace function f_insertar_carrera 
(_carrera character varying) returns void
as 
$$
	insert into t_usuario (vc_carrera) values (_carrera);
$$
language sql
--------------------------------------------------------------
select f_insertar_carrera('administración')
select * from t_carrera
--------------------------------------------------------------
--------------------------------------------------------------

create or replace function f_eliminar_carrera (_pk integer) returns void
as
$$
	delete from t_carrera where i_pk_carrera = _pk
$$
language sql
--------------------------------------------------------------
select from f_eliminar_carrera(8)
select * from t_carrera
--------------------------------------------------------------
--------------------------------------------------------------

create or replace function f_modificar_carrera
(_carrera character varying, _pk integer) returns void
as 
$$
	update t_carrera set vc_carrera = _carrera where i_pk_carrera = _pk;
$$
language sql
--------------------------------------------------------------
select from f_modificar_carrera('derecho', 8)
select * from t_carrera

--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
------------------------TABLA-USUARIO-------------------------
--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

create or replace function f_insertar_usuario
(
	_fk_perfil integer,
	_usuario character varying,
	_clave character varying
) returns void
as 
$$
	insert into t_usuario (i_fk_perfil, vc_usuario, vc_clave) values (_fk_perfil, _usuario, _clave);
$$
language sql
--------------------------------------------------------------
select f_insertar_usuario(2, 'alonso', 'al')
select * from t_usuario
--------------------------------------------------------------
--------------------------------------------------------------

create or replace function f_eliminar_usuario (_pk integer) returns void
as
$$
	delete from t_usuario where i_pk_usuario = _pk
$$
language sql
--------------------------------------------------------------
select * from f_eliminar_usuario(3)
select * from t_carrera
--------------------------------------------------------------
--------------------------------------------------------------

create or replace function f_modificar_usuario_especifico
(_pk integer, _campo character varying) returns void
as 
$$
	update t_usuario set vc_ = _carrera where i_pk_carrera = _pk;
$$
language sql
--------------------------------------------------------------
select * from f_modificar_carrera('administracion', 6)
select * from t_carrera
--------------------------------------------------------------
--------------------------------------------------------------

