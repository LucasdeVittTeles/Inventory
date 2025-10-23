import api from "../api/api";

export const listarProdutos = async () => {
    const response = await api.get("/product");
    return response.data;
};