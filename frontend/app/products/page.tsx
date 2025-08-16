'use client';

import { useEffect, useState } from 'react';

type Product = {
  id: number;
  name: string;
  price: number;
};

export default function ProductsPage() {
  const [products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    fetch(`${process.env.NEXT_PUBLIC_API_URL}/products`)
      .then((res) => res.json())
      .then((data) => setProducts(data));
  }, []);

  return (
    <div className="p-6">
      <h1 className="text-2xl font-bold mb-4">Ürünler</h1>
      <ul className="space-y-2">
        {products.map((p) => (
          <li key={p.id} className="border p-3 rounded">
            <span className="font-medium">{p.name}</span> - {p.price} ₺
          </li>
        ))}
      </ul>
    </div>
  );
}
