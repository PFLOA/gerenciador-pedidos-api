³
~D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Body\CriarClienteRequestBody.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
Body, 0
{ 
public 
class	 #
CriarClienteRequestBody &
{		 
public

 

string

 
NomeCliente

 
{

 
get

  #
;

# $
set

% (
;

( )
}

* +
public 

Cliente 
ToModel 
( 
) 
{ 
return 
new 
Cliente 
( 
this 
) 
; 
} 
} 
} Í
~D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Body\CriarProdutoRequestBody.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
Body, 0
{ 
public 

class #
CriarProdutoRequestBody (
{ 
public 
string 
NomeProduto !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
decimal 
Preco 
{ 
get "
;" #
set$ '
;' (
}) *
public

 
Produto

 
ToModel

 
(

 
)

  
{ 	
return 
new 
Produto 
( 
this #
)# $
;$ %
} 	
} 
} ÷	
~D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Body\CriarUsuarioRequestBody.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
Body, 0
{ 
public 
class	 #
CriarUsuarioRequestBody &
{ 
public 

string 
Nome 
{ 
get 
; 
set !
;! "
}# $
public		 

string		 
Senha		 
{		 
get		 
;		 
set		 "
;		" #
}		$ %
public

 

string

 
UserName

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
public 

string 
Email 
{ 
get 
; 
set "
;" #
}$ %
public 

Usuario 
ToModel 
( 
) 
{ 
throw 
new #
NotImplementedException '
(' (
)( )
;) *
} 
} 
} Œ
sD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Entidades\Cliente.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
	Entidades, 5
{ 
public 
class	 
Cliente 
: 
Entity 
<  
short  %
>% &
{ 
public 

string 
NomeCliente 
{ 
get  #
;# $
set% (
;( )
}* +
public		 

Cliente		 
(		 
)		 
{

 
} 
public 

Cliente 
( #
CriarClienteRequestBody *
requestBody+ 6
)6 7
{ 
requestBody 
. 
MappingProperties #
(# $
this$ (
)( )
;) *
} 
} 
} Í
rD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Entidades\Entity.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
	Entidades, 5
{ 
public 

class 
Entity 
< 
TType 
> 
{ 
public 
TType 
Id 
{ 
get 
; 
set "
;" #
}$ %
public 
Guid 
Guid 
{ 
get 
; 
set  #
;# $
}% &
=' (
Guid) -
.- .
NewGuid. 5
(5 6
)6 7
;7 8
public		 
DateTime		 
DataCadastro		 $
{		% &
get		' *
;		* +
set		, /
;		/ 0
}		1 2
=		3 4
DateTime		5 =
.		= >
Now		> A
;		A B
}

 
} ¼
qD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Entidades\Login.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
	Entidades, 5
{ 
public 

class 
Login 
{ 
public 
string 
UserName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Senha 
{ 
get !
;! "
set# &
;& '
}( )
} 
} °	
sD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Entidades\Produto.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
	Entidades, 5
{ 
public		 

class		 
Produto		 
:		 
Entity		 !
<		! "
short		" '
>		' (
{

 
public 
string 
NomeProduto !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
decimal 
Preco 
{ 
get "
;" #
set$ '
;' (
}) *
public 
Produto 
( 
) 
{ 
} 
public 
Produto 
( #
CriarProdutoRequestBody .#
criarProdutoRequestBody/ F
)F G
=>H J#
criarProdutoRequestBodyK b
.b c
MappingPropertiesc t
(t u
thisu y
)y z
;z {
} 
} ã
sD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Entidades\Usuario.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
	Entidades, 5
{ 
public 

class 
Usuario 
: 
Entity !
<! "
short" '
>' (
{ 
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
Senha 
{ 
get !
;! "
set# &
;& '
}( )
public		 
string		 
UserName		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
public

 
string

 
Email

 
{

 
get

 !
;

! "
set

# &
;

& '
}

( )
public 
Usuario 
( 
) 
{ 	
} 	
public 
Usuario 
( 
string 
nome "
," #
string$ *
senha+ 0
,0 1
string2 8
userName9 A
,A B
stringC I
emailJ O
,O P
GuidQ U
guidV Z
)Z [
{ 	
Nome 
= 
nome 
; 
Senha 
= 
senha 
; 
UserName 
= 
userName 
;  
Email 
= 
email 
; 
Guid 
= 
guid 
; 
} 	
} 
} –
rD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Enum\NivelAcesso.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
Enum, 0
{ 
public 

enum 
NivelAcesso 
{ 
Administrador		 
,		 
	Diretoria

 
,

 
Gerencia 
, 
Operacional 
} 
} ¢
sD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Enum\RetornosEnum.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
Enum, 0
{ 
public 

enum 
RetornosEnum 
{ 
UserNotFound		 
,		 
UserUpdated

 
,

 
UserDifferentId 
, 
ParameterNull 
} 
} –
„D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Filters\BuscarClientesFiltroFilter.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
Filters, 3
{ 
public 

class &
BuscarClientesFiltroFilter +
:, -

BaseFilter. 8
{		 
public 
string 
NomeCliente !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTime 
DataCadastro $
{% &
get' *
;* +
set, /
;/ 0
}1 2
} 
} °
„D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Filters\BuscarProdutosFiltroFilter.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
Filters, 3
{ 
public 

class &
BuscarProdutosFiltroFilter +
:, -

BaseFilter. 8
{ 
public 
string 
NomeProduto !
{" #
get$ '
;' (
set) ,
;, -
}. /
public		 
DateTime		 
DataCadastro		 $
{		% &
get		' *
;		* +
set		, /
;		/ 0
}		1 2
public

 
decimal

 
Preco

 
{

 
get

 "
;

" #
set

$ '
;

' (
}

) *
} 
} ”
~D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Interface\IClienteRepository.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
	Interface, 5
{ 
public 

	interface 
IClienteRepository '
{		 

IQueryable

 
<

 
Cliente

 
>

 #
BuscarClientesPorFiltro

 3
(

3 4&
BuscarClientesFiltroFilter

4 N
filter

O U
)

U V
;

V W
Cliente 
CriarCliente 
( #
CriarClienteRequestBody 4
cliente5 <
)< =
;= >
} 
} Ú
|D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Interface\ILoginRepository.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
	Interface, 5
{ 
public 

	interface 
ILoginRepository %
{ 
Usuario 
	LoginUser 
( 
string  
userName! )
,) *
string+ 1
senha2 7
)7 8
;8 9
} 
}		 ”
~D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Interface\IProdutoRepository.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
	Interface, 5
{ 
public 

	interface 
IProdutoRepository '
{		 

IQueryable

 
<

 
Produto

 
>

 #
BuscarProdutosPorFiltro

 3
(

3 4&
BuscarProdutosFiltroFilter

4 N
filter

O U
)

U V
;

V W
Produto 
CriarProduto 
( #
CriarProdutoRequestBody 4
produto5 <
)< =
;= >
} 
} »
~D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Interface\IUsuarioRepository.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
	Interface, 5
{ 
public 

	interface 
IUsuarioRepository '
{ 
Usuario 
CriarUsuario 
( #
CriarUsuarioRequestBody 4
usuario5 <
)< =
;= >
}		 
}

 