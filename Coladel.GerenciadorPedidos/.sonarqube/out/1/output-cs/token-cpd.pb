¦
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
virtual 
Cliente 
ToModel "
(" #
)# $
=>% '
new( +
Cliente, 3
(3 4
this4 8
)8 9
;9 :
} 
} ×
vD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Body\CriarPedidoBody.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
Body, 0
{ 
public		 

class		 
CriarPedidoBody		  
{

 
public 
StatusPedido 
StatusPedido (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
List 
< 
Produto 
> 
ProdutosList )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
Cliente 
Cliente 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
NF 
{ 
get 
; 
set  #
;# $
}% &
public 
string 
Observacoes !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
decimal 
Total 
{ 
get "
;" #
set$ '
;' (
}) *
public 
virtual 
Pedido 
ToModel %
(% &
)& '
=>( *
new+ .
Pedido/ 5
(5 6
this6 :
): ;
;; <
} 
} À
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
public		 
virtual		 
Produto		 
ToModel		 &
(		& '
)		' (
=>		) +
new		, /
Produto		0 7
(		7 8
this		8 <
)		< =
;		= >
}

 
} ÷	
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
} Í
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
{		 
}		 
public

 

Cliente

 
(

 #
CriarClienteRequestBody

 *
requestBody

+ 6
)

6 7
=>

9 ;
requestBody

< G
.

G H
MappingProperties

H Y
(

Y Z
this

Z ^
)

^ _
;

_ `
} 
} œ
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
{ 
public 
short 
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
} ½
rD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Entidades\Pedido.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
	Entidades, 5
{ 
public 

class 
Pedido 
: 
Entity  
{		 
public

 
StatusPedido

 
StatusPedido

 (
{

) *
get

+ .
;

. /
set

0 3
;

3 4
}

5 6
public 
virtual 
Cliente 
Cliente &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
List 
< 
Produto 
> 
ProdutosList )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
string 
NF 
{ 
get 
; 
set  #
;# $
}% &
public 
string 
Observacoes !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
short 
	IdCliente 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
decimal 
Total 
{ 
get "
;" #
set$ '
;' (
}) *
public 
Pedido 
( 
) 
{ 
} 
public 
Pedido 
( 
CriarPedidoBody %
criarPedidoBody& 5
)5 6
=>7 9
criarPedidoBody: I
.I J
MappingPropertiesJ [
([ \
this\ `
)` a
;a b
} 
} ÿ
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
} ²
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
} ì
sD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Enum\StatusPedido.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
Enum, 0
{ 
public 

enum 
StatusPedido 
{ 
ENTREGUE 
, 
EM_ANDAMENTO 
, 
ATRASO 
} 
}		 –
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
} À	
ƒD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Filters\BuscarPedidosFiltroFilter.cs
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
class %
BuscarPedidosFiltroFilter *
{ 
public 
StatusPedido 
StatusPedido (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public		 
string		 
Cliente		 
{		 
get		  #
;		# $
set		% (
;		( )
}		* +
public

 
string

 
Produto

 
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
public 
string 
NF 
{ 
get 
; 
set  #
;# $
}% &
public 
DateTime 
DataCadastro $
{% &
get' *
;* +
set, /
;/ 0
}1 2
} 
} °
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
} Ò
~D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Interface\IClienteRepository.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
	Interface, 5
{ 
public		 

	interface		 
IRepository		  
:		! "
IRepository		# .
<		. /
Cliente		/ 6
>		6 7
{

 

IQueryable 
< 
Cliente 
> #
BuscarClientesPorFiltro 3
(3 4&
BuscarClientesFiltroFilter4 N
filterO U
)U V
;V W
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
}		 ý
}D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Interface\IPedidoRepository.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
	Interface, 5
{ 
public		 

	interface		 
IPedidoRepository		 &
:		' (
IRepository		) 4
<		4 5
Pedido		5 ;
>		; <
{

 
} 
} Ù
~D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Domain\Interface\IProdutoRepository.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Domain% +
.+ ,
	Interface, 5
{ 
public		 

	interface		 
IProdutoRepository		 '
:		( )
IRepository		* 5
<		5 6
Produto		6 =
>		= >
{

 

IQueryable 
< 
Produto 
> #
BuscarProdutosPorFiltro 3
(3 4&
BuscarProdutosFiltroFilter4 N
filterO U
)U V
;V W
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