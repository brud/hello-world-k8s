# Развертывание
1. Установить Docker
2. Установить Kind
3. `kind create cluster`
4. `kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/main/deploy/static/provider/kind/deploy.yaml`
5. `kubectl delete -A ValidatingWebhookConfiguration ingress-nginx-admission` (monkey fix, не для продакшена)
6. `kubectl apply -f .\_k8s\`