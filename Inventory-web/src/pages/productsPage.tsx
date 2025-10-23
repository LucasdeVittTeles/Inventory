import { useEffect, useState } from "react";
import { listarProdutos } from "../services/productService";

export default function ProdutosPage() {
    const [produtos, setProdutos] = useState<any[]>([]);

    useEffect(() => {
        listarProdutos().then(setProdutos);
    }, []);

    return (
        <div className="p-4">
            <h1>📦 Controle de Estoque</h1>
            <table>
                <thead>
                    <tr><th>ID</th><th>Nome</th><th>Qtd</th><th>Preço</th></tr>
                </thead>
                <tbody>
                    {produtos.map(p => (
                        <tr key={p.id}>
                            <td>{p.id}</td><td>{p.nome}</td><td>{p.quantidade}</td><td>{p.preco}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}