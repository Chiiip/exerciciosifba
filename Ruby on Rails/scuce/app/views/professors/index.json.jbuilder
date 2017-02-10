json.array!(@professors) do |professor|
  json.extract! professor, :id, :name, :phone, :email, :password
  json.url professor_url(professor, format: :json)
end
