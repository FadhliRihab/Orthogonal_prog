function Dot_product (@V1:array;@V2:array):integer
variabl
i,n:integer 
begin 
s=0
for i from 0 to n do 
    s= s +V1[i]* V2[i]
end  
Dot_product=s
end .
algorithm Prog_dot
variabl
i,n:integer 
Dot_product : integer
begin
for i from 0 to n do
if (Dot_product(V[i],V[i+1])==0) then  
     write("orthogonal") 
else   
    write("not orthogonal")
end   
end.