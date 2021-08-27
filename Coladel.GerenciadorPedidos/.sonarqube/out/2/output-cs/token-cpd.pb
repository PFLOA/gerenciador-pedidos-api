Ω
tD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Authentication\AuthenticationJwt.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Authentication% 3
{ 
public 

static 
class 
AuthenticationJwt )
{ 
public 
static 
byte 
[ 
] )
InitConfigureJwtAuthetication :
(: ;
string; A
jwtKeyConfiguratioB T
)T U
{ 	
return		 
Encoding		 
.		 
ASCII		 !
.		! "
GetBytes		" *
(		* +
jwtKeyConfiguratio		+ =
)		= >
;		> ?
}

 	
} 
} ù
âD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Clientes\Handler\BuscarClientesFiltroHandler.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Clientes' /
./ 0
Handler0 7
{ 
public 

class '
BuscarClientesFiltroHandler ,
:- .
IRequestHandler/ >
<> ?'
BuscarClientesFiltroRequest? Z
,Z [
IActionResult\ i
>i j
{ 
private 
readonly 
IClienteRepository +
_clienteRepository, >
;> ?
public '
BuscarClientesFiltroHandler *
(* +
IClienteRepository+ =
produtoRepository> O
)O P
{ 	
_clienteRepository 
=  
produtoRepository! 2
;2 3
} 	
public 
async 
Task 
< 
IActionResult '
>' (
Handle) /
(/ 0'
BuscarClientesFiltroRequest0 K
requestL S
,S T
CancellationTokenU f
cancellationTokeng x
)x y
{ 	
Func 
< 
Cliente 
, (
BuscarClientesFiltroResponse 6
>6 7
retorno8 ?
=@ A

ConstrutorB L
;L M
try 
{ 

IQueryable 
< 
Cliente "
>" #
clientes$ ,
=- .
_clienteRepository/ A
.A B#
BuscarClientesPorFiltroB Y
(Y Z
requestZ a
)a b
;b c
return 
await 
Task !
.! "

FromResult" ,
(, -
PaginatedResult- <
<< =(
BuscarClientesFiltroResponse= Y
>Y Z
.Z [
CreateSuccess[ h
(h i
requesti p
,p q
clientesr z
,z {
retorno	| É
)
É Ñ
)
Ñ Ö
;
Ö Ü
} 
catch   
(   
	Exception   
ex   
)    
{!! 
return"" 
await"" 
Task"" !
.""! "

FromResult""" ,
("", -
new""- 0"
BadRequestObjectResult""1 G
(""G H
new""H K
{""L M
Errors""N T
=""U V
new""W Z
[""Z [
]""[ \
{""] ^
$"""_ a
{""a b
ex""b d
.""d e
Message""e l
}""l m
"""m n
}""o p
}""q r
)""r s
)""s t
;""t u
}## 
}$$ 	
public%% (
BuscarClientesFiltroResponse%% +

Construtor%%, 6
(%%6 7
Cliente%%7 >
cliente%%? F
)%%F G
{&& 	
return'' 
new'' (
BuscarClientesFiltroResponse'' 3
(''3 4
cliente''4 ;
)''; <
;''< =
}(( 	
}** 
}++ Î
ÅD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Clientes\Handler\CriarClienteHandler.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Clientes' /
{ 
public 
class	 
CriarClienteHandler "
:# $
IRequestHandler% 4
<4 5
CriarClienteRequest5 H
,H I
IActionResultJ W
>W X
{ 
private 
readonly 
IClienteRepository '
_clienteRepository( :
;: ;
public 

CriarClienteHandler 
( 
IClienteRepository 1
produtoRepository2 C
)C D
{ 
_clienteRepository 
= 
produtoRepository ,
;, -
} 
public 

async 
Task 
< 
IActionResult #
># $
Handle% +
(+ ,
CriarClienteRequest, ?
request@ G
,G H
CancellationTokenI Z
cancellationToken[ l
)l m
{ 
try 	
{ 
Cliente 
cliente 
= 
_clienteRepository ,
., -
CriarCliente- 9
(9 :
request: A
)A B
;B C
return 
await 
Task 
. 

FromResult $
($ %
new% (
OkObjectResult) 7
(7 8
new8 ;
{< =
Produto> E
=F G
newH K 
CriarClienteResponseL `
(` a
clientea h
)h i
}j k
)k l
)l m
;m n
} 
catch 
( 
	Exception 
ex 
) 
{   
return!! 
await!! 
Task!! 
.!! 

FromResult!! $
(!!$ %
new!!% ("
BadRequestObjectResult!!) ?
(!!? @
new!!@ C
{!!D E
Errors!!F L
=!!M N
new!!O R
[!!R S
]!!S T
{!!U V
$"!!W Y
{!!Y Z
ex!!Z \
.!!\ ]
Message!!] d
}!!d e
"!!e f
}!!g h
}!!i j
)!!j k
)!!k l
;!!l m
}"" 
}## 
}$$ 
}%% È
âD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Clientes\Request\BuscarClientesFiltroRequest.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Clientes' /
./ 0
Request0 7
{ 
public 

class '
BuscarClientesFiltroRequest ,
:- .&
BuscarClientesFiltroFilter/ I
,I J
IRequestK S
<S T
IActionResultT a
>a b
{ 
}		 
}

 ÷
ÅD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Clientes\Request\CriarClienteRequest.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Clientes' /
./ 0
Request0 7
{ 
public 
class	 
CriarClienteRequest "
:# $#
CriarClienteRequestBody% <
,< =
IRequest> F
<F G
IActionResultG T
>T U
{V W
}X Y
} ≥
ãD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Clientes\Response\BuscarClientesFiltroResponse.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Clientes' /
./ 0
Response0 8
{ 
public		 

class		 (
BuscarClientesFiltroResponse		 -
{

 
public 
string 
NomeCliente !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
Guid 
Guid 
{ 
get 
; 
set  #
;# $
}% &
public (
BuscarClientesFiltroResponse +
(+ ,
Cliente, 3
cliente4 ;
); <
{ 	
cliente 
. 
MappingProperties %
(% &
this& *
)* +
;+ ,
} 	
} 
} Ω	
ÉD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Clientes\Response\CriarClienteResponse.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Clientes' /
./ 0
Response0 8
{ 
public 
class	  
CriarClienteResponse #
{ 
public		 

Guid		 
Guid		 
{		 
get		 
;		 
set		 
;		  
}		! "
public

 

DateTime

 
DataCadastro

  
{

! "
get

# &
;

& '
set

( +
;

+ ,
}

- .
public 

string 
NomeCliente 
{ 
get  #
;# $
set% (
;( )
}* +
public 
 
CriarClienteResponse 
(  
Cliente  '
cliente( /
)/ 0
{ 
cliente 
. 
MappingProperties 
(  
this  $
)$ %
;% &
} 
} 
} ” 
D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Login\Handler\RealizarLoginHandler.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Login' ,
., -
Handler- 4
{ 
public 

class  
RealizarLoginHandler %
:& '
IRequestHandler( 7
<7 8 
RealizarLoginRequest8 L
,L M
IActionResultN [
>[ \
{ 
private 
readonly 
ILoginRepository )
_loginRepository* :
;: ;
public  
RealizarLoginHandler #
(# $
ILoginRepository$ 4
loginRepository5 D
)D E
{ 	
_loginRepository 
= 
loginRepository .
;. /
} 	
public 
async 
Task 
< 
IActionResult '
>' (
Handle) /
(/ 0 
RealizarLoginRequest0 D
requestE L
,L M
CancellationTokenN _
cancellationToken` q
)q r
{ 	
try 
{ 
if 
( 
string 
. 
IsNullOrEmpty (
(( )
request) 0
.0 1
UserName1 9
)9 :
||; =
string> D
.D E
IsNullOrEmptyE R
(R S
requestS Z
.Z [
Senha[ `
)` a
)a b
returnc i
awaitj o
Taskp t
.t u

FromResultu 
(	 Ä
new
Ä É$
BadRequestObjectResult
Ñ ö
(
ö õ
new
õ û
{
ü †
Errors
° ß
=
® ©
new
™ ≠
[
≠ Æ
]
Æ Ø
{
∞ ±
$"
≤ ¥
$str
¥ Õ
"
Õ Œ
}
œ –
}
— “
)
“ ”
)
” ‘
;
‘ ’
Usuario 
usuario 
=  !
_loginRepository" 2
.2 3
	LoginUser3 <
(< =
request= D
.D E
UserNameE M
,M N
requestO V
.V W
SenhaW \
)\ ]
;] ^
if 
( 
usuario 
== 
null #
)# $
return% +
new, / 
NotFoundObjectResult0 D
(D E
newE H
{I J
ErrorsK Q
=R S
newT W
[W X
]X Y
{Z [
$str\ z
}{ |
}} ~
)~ 
;	 Ä
string 
generatedToken %
=& '

RetornoJwt( 2
.2 3
RetornoJwtString3 C
(C D
usuarioD K
)K L
;L M
return   
await   
Task   !
.  ! "

FromResult  " ,
(  , -
new  - 0
OkObjectResult  1 ?
(  ? @
new  @ C
{  D E
Token  F K
=  L M
generatedToken  N \
,  \ ]
Usuario  ^ e
=  f g
new  h k"
RealizarLoginResponse	  l Å
(
  Å Ç
usuario
  Ç â
)
  â ä
}
  ã å
)
  å ç
)
  ç é
;
  é è
}!! 
catch"" 
("" 
	Exception"" 
ex"" 
)""  
{## 
return$$ 
await$$ 
Task$$ !
.$$! "

FromResult$$" ,
($$, -
new$$- 0"
BadRequestObjectResult$$1 G
($$G H
new$$H K
{$$L M
Errors$$N T
=$$U V
new$$W Z
[$$Z [
]$$[ \
{$$] ^
$"$$_ a
{$$a b
ex$$b d
.$$d e
Message$$e l
}$$l m
"$$m n
}$$o p
}$$q r
)$$r s
)$$s t
;$$t u
}%% 
}&& 	
}'' 
}(( “
D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Login\Request\RealizarLoginRequest.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Login' ,
., -
Request- 4
{ 
public		 

class		  
RealizarLoginRequest		 %
:		& '
IRequest		( 0
<		0 1
IActionResult		1 >
>		> ?
{

 
public 
string 
UserName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Senha 
{ 
get !
;! "
set# &
;& '
}( )
} 
} ∏

ÅD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Login\Response\RealizarLoginResponse.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Login' ,
., -
Response- 5
{ 
public 

class !
RealizarLoginResponse &
{ 
public		 
Guid		 
Guid		 
{		 
get		 
;		 
set		  #
;		# $
}		% &
public

 
string

 
Nome

 
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
public 
string 
UserName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
public !
RealizarLoginResponse $
($ %
Usuario% ,
usuario- 4
)4 5
=>6 8
usuario9 @
.@ A
MappingPropertiesA R
(R S
thisS W
)W X
;X Y
} 
} ù
âD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Produtos\Handler\BuscarProdutosFiltroHandler.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Produtos' /
./ 0
Handler0 7
{ 
public 

class '
BuscarProdutosFiltroHandler ,
:- .
IRequestHandler/ >
<> ?'
BuscarProdutosFiltroRequest? Z
,Z [
IActionResult\ i
>i j
{ 
private 
readonly 
IProdutoRepository +
_produtoRepository, >
;> ?
public '
BuscarProdutosFiltroHandler *
(* +
IProdutoRepository+ =
produtoRepository> O
)O P
{ 	
_produtoRepository 
=  
produtoRepository! 2
;2 3
} 	
public 
async 
Task 
< 
IActionResult '
>' (
Handle) /
(/ 0'
BuscarProdutosFiltroRequest0 K
requestL S
,S T
CancellationTokenU f
cancellationTokeng x
)x y
{ 	
Func 
< 
Produto 
, (
BuscarProdutosFiltroResponse 6
>6 7
retorno8 ?
=@ A

ConstrutorB L
;L M
try 
{ 

IQueryable 
< 
Produto "
>" #
produtos$ ,
=- .
_produtoRepository/ A
.A B#
BuscarProdutosPorFiltroB Y
(Y Z
requestZ a
)a b
;b c
return 
await 
Task !
.! "

FromResult" ,
(, -
PaginatedResult- <
<< =(
BuscarProdutosFiltroResponse= Y
>Y Z
.Z [
CreateSuccess[ h
(h i
requesti p
,p q
produtosr z
,z {
retorno	| É
)
É Ñ
)
Ñ Ö
;
Ö Ü
} 
catch 
( 
	Exception 
ex 
)  
{   
return!! 
await!! 
Task!! !
.!!! "

FromResult!!" ,
(!!, -
new!!- 0"
BadRequestObjectResult!!1 G
(!!G H
new!!H K
{!!L M
Errors!!N T
=!!U V
new!!W Z
[!!Z [
]!![ \
{!!] ^
$"!!_ a
{!!a b
ex!!b d
.!!d e
Message!!e l
}!!l m
"!!m n
}!!o p
}!!q r
)!!r s
)!!s t
;!!t u
}"" 
}## 	
public$$ (
BuscarProdutosFiltroResponse$$ +

Construtor$$, 6
($$6 7
Produto$$7 >
produto$$? F
)$$F G
{%% 	
return&& 
new&& (
BuscarProdutosFiltroResponse&& 3
(&&3 4
produto&&4 ;
)&&; <
;&&< =
}'' 	
}(( 
})) è
ÅD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Produtos\Handler\CriarProdutoHandler.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Produtos' /
./ 0
Handler0 7
{ 
public 

class 
CriarProdutoHandler $
:% &
IRequestHandler' 6
<6 7
CriarProdutoRequest7 J
,J K
IActionResultL Y
>Y Z
{ 
private 
readonly 
IProdutoRepository +
_produtoRepository, >
;> ?
public 
CriarProdutoHandler "
(" #
IProdutoRepository# 5
produtoRepository6 G
)G H
{ 	
_produtoRepository 
=  
produtoRepository! 2
;2 3
} 	
public 
async 
Task 
< 
IActionResult '
>' (
Handle) /
(/ 0
CriarProdutoRequest0 C
requestD K
,K L
CancellationTokenM ^
cancellationToken_ p
)p q
{ 	
try 
{ 
Produto 
produto 
=  !
_produtoRepository" 4
.4 5
CriarProduto5 A
(A B
requestB I
)I J
;J K
return 
await 
Task !
.! "

FromResult" ,
(, -
new- 0
OkObjectResult1 ?
(? @
new@ C
{D E
ProdutoF M
=N O
newP S 
CriarProdutoResponseT h
(h i
produtoi p
)p q
}r s
)s t
)t u
;u v
} 
catch 
( 
	Exception 
ex 
)  
{ 
return 
await 
Task !
.! "

FromResult" ,
(, -
new- 0"
BadRequestObjectResult1 G
(G H
newH K
{L M
ErrorsN T
=U V
newW Z
[Z [
][ \
{] ^
$"_ a
{a b
exb d
.d e
Messagee l
}l m
"m n
}o p
}q r
)r s
)s t
;t u
} 
}   	
}!! 
}"" È
âD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Produtos\Request\BuscarProdutosFiltroRequest.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Produtos' /
./ 0
Request0 7
{ 
public 

class '
BuscarProdutosFiltroRequest ,
:- .&
BuscarProdutosFiltroFilter/ I
,I J
IRequestK S
<S T
IActionResultT a
>a b
{ 
}		 
}

 ÷
ÅD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Produtos\Request\CriarProdutoRequest.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Produtos' /
./ 0
Request0 7
{ 
public 

class 
CriarProdutoRequest $
:% &#
CriarProdutoRequestBody' >
,> ?
IRequest@ H
<H I
IActionResultI V
>V W
{		 
} 
} ·

ãD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Produtos\Response\BuscarProdutosFiltroResponse.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Produtos' /
./ 0
Response0 8
{ 
public 

class (
BuscarProdutosFiltroResponse -
{ 
public		 
Guid		 
Guid		 
{		 
get		 
;		 
set		  #
;		# $
}		% &
public

 
string

 
NomeProduto

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
public 
decimal 
Preco 
{ 
get "
;" #
set$ '
;' (
}) *
public 
DateTime 
DataCadastro $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public (
BuscarProdutosFiltroResponse +
(+ ,
Produto, 3
produto4 ;
); <
=>= ?
produto@ G
.G H
MappingPropertiesH Y
(Y Z
thisZ ^
)^ _
;_ `
} 
} …

ÉD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Produtos\Response\CriarProdutoResponse.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Produtos' /
./ 0
Response0 8
{ 
public 

class  
CriarProdutoResponse %
{ 
public		 
string		 
NomeProduto		 !
{		" #
get		$ '
;		' (
set		) ,
;		, -
}		. /
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
) *
public 
Guid 
Guid 
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
}1 2
public  
CriarProdutoResponse #
(# $
Produto$ +
produto, 3
)3 4
=>5 7
produto8 ?
.? @
MappingProperties@ Q
(Q R
thisR V
)V W
;W X
} 
} è
ÅD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Usuarios\Handler\CriarUsuarioHandler.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Usuarios' /
./ 0
Handler0 7
{ 
public 
class	 
CriarUsuarioHandler "
:# $
IRequestHandler% 4
<4 5
CriarUsuarioRequest5 H
,H I
IActionResultJ W
>W X
{ 
private 
readonly 
IUsuarioRepository '
_usuarioRepository( :
;: ;
public 

CriarUsuarioHandler 
( 
IUsuarioRepository 1
usuarioRepository2 C
)C D
{ 
_usuarioRepository 
= 
usuarioRepository ,
;, -
} 
public 

async 
Task 
< 
IActionResult #
># $
Handle% +
(+ ,
CriarUsuarioRequest, ?
request@ G
,G H
CancellationTokenI Z
cancellationToken[ l
)l m
{ 
try 	
{ 
Usuario 
usuario 
= 
_usuarioRepository ,
., -
CriarUsuario- 9
(9 :
request: A
)A B
;B C
return 
await 
Task 
. 

FromResult $
($ %
new% (
OkObjectResult) 7
(7 8
new8 ;
{< =
Usuario> E
=F G
newH K 
CriarUsuarioResponseL `
(` a
usuarioa h
)h i
}j k
)k l
)l m
;m n
} 
catch 
( 
	Exception 
ex 
) 
{ 
return 
await 
Task 
. 

FromResult $
($ %
new% ("
BadRequestObjectResult) ?
(? @
new@ C
{D E
ErrorsF L
=M N
newO R
[R S
]S T
{U V
$"W Y
{Y Z
exZ \
.\ ]
Message] d
}d e
"e f
}g h
}i j
)j k
)k l
;l m
} 
}   
}!! 
}"" ú
ÅD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Usuarios\Request\CriarUsuarioRequest.cs
	namespace 	
Coladel
 
. 
Application 
. 
Handlers &
.& '
Login' ,
., -
Handler- 4
.4 5
Usuarios5 =
.= >
Request> E
{ 
public 

class 
CriarUsuarioRequest $
:% &#
CriarUsuarioRequestBody' >
,> ?
IRequest@ H
<H I
IActionResultI V
>V W
{		 
}

 
} ∂
ÉD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\Handlers\Usuarios\Response\CriarUsuarioResponse.cs
	namespace

 	
Coladel


 
.

 
Application

 
.

 
Handlers

 &
.

& '
Usuarios

' /
.

/ 0
Response

0 8
{ 
public 

class  
CriarUsuarioResponse %
{ 
private 
string 
_senha 
; 
public 
Guid 
Guid 
{ 
get 
; 
set  #
;# $
}% &
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
Senha 
{ 	
get 
{ 
Hash 
hash 
= 
new 
Hash  $
($ %
SHA512% +
.+ ,
Create, 2
(2 3
)3 4
)4 5
;5 6
string 
senha 
= 
hash #
.# $
CriptografarSenha$ 5
(5 6
_senha6 <
)< =
;= >
string 
salt 
= 
Hash "
." #

CreateSalt# -
(- .
Guid. 2
.2 3
ToInt323 :
(: ;
); <
)< =
;= >
return 
$" 
{ 
senha 
}  
{  !
salt! %
}% &
"& '
;' (
} 
set 
{ 
_senha 
= 
value 
; 
} 
}   	
public!! 
string!! 
UserName!! 
{!!  
get!!! $
;!!$ %
set!!& )
;!!) *
}!!+ ,
public"" 
string"" 
Email"" 
{"" 
get"" !
;""! "
set""# &
;""& '
}""( )
public$$  
CriarUsuarioResponse$$ #
($$# $
Usuario$$$ +
usuario$$, 3
)$$3 4
{%% 	
usuario&& 
.&& 
MappingProperties&& %
(&&% &
this&&& *
)&&* +
;&&+ ,
}'' 	
public)) 
Usuario)) 
ToUsuarioModel)) %
())% &
)))& '
{** 	
return++ 
new++ 
Usuario++ 
(++ 
Nome++ #
,++# $
Senha++% *
,++* +
UserName++, 4
,++4 5
Email++6 ;
,++; <
Guid++= A
)++A B
;++B C
},, 	
}-- 
}..  
bD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.Application\JWT\RetornoJwt.cs
	namespace		 	
Coladel		
 
.		 
GerenciadorPedidos		 $
.		$ %
JWT		% (
{

 
public 

static 
class 

RetornoJwt "
{ 
public 
static 
string 
RetornoJwtString -
(- .
Usuario. 5
result6 <
)< =
{ 	
var 
secret 
= 
Encoding !
.! "
ASCII" '
.' (
GetBytes( 0
(0 1
$str1 [
)[ \
;\ ]
var  
symmetricSecurityKey $
=% &
new' * 
SymmetricSecurityKey+ ?
(? @
secret@ F
)F G
;G H
var #
securityTokenDescriptor '
=( )
new* -#
SecurityTokenDescriptor. E
{ 
Subject 
= 
new 
ClaimsIdentity ,
(, -
new- 0
Claim1 6
[6 7
]7 8
{ 
new 
Claim 
( 

ClaimTypes '
.' (
NameIdentifier( 6
,6 7
result8 >
.> ?
Id? A
.A B
ToStringB J
(J K
)K L
)L M
,M N
new 
Claim 
( 

ClaimTypes '
.' (
Email( -
,- .
result/ 5
.5 6
Email6 ;
); <
,< =
new 
Claim 
( 

ClaimTypes '
.' (
Name( ,
,, -
result. 4
.4 5
UserName5 =
)= >
} 
) 
, 
Expires 
= 
DateTime "
." #
UtcNow# )
.) *
AddDays* 1
(1 2
$num2 3
)3 4
,4 5
SigningCredentials "
=# $
new% (
SigningCredentials) ;
(; < 
symmetricSecurityKey< P
,P Q
SecurityAlgorithmsR d
.d e
HmacSha256Signaturee x
)x y
} 
; 
var #
jwtSecurityTokenHandler '
=( )
new* -#
JwtSecurityTokenHandler. E
(E F
)F G
;G H
var 
tokenGenerated 
=  #
jwtSecurityTokenHandler! 8
.8 9
CreateToken9 D
(D E#
securityTokenDescriptorE \
)\ ]
;] ^
return   #
jwtSecurityTokenHandler   *
.  * +

WriteToken  + 5
(  5 6
tokenGenerated  6 D
)  D E
;  E F
}!! 	
}"" 
}## 