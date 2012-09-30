Fonctionnalité: Paiment des items du panier
	En tant que client, je veux payer les items dans mon panier.

Contexte: 
	Étant donné que je suis un client authentifié

Scénario: Saisir les informations pour le paiement et confirmer l'achat

	Étant donné que je suis sur la page du panier d'achat
	Quand je clique sur lien Commander
	Et que je saisi les informations suivantes
		| Champ | Valeur |
		| Prénom | Joe |
		| Nom | Légumineuse |
		| Adresse | 1234 rue Fictive |
		| Ville | Ivujiivik |
		| Province | Québec |
		| Code postal | G1Q 1Q9 |
		| Pays | Canada |
		| Téléphone | 418-555-1234 |
		| Courriel | joelegumineuse@brocoli.com |
		| Code Promo | FREE |
	Et que je soumet le formulaire
	Alors mon paiment est complété avec succès