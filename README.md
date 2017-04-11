Dependency Injection Örneği

- İşlemler için Core, Ui için Console App. katmanı oluşturuldu.
- Her bir ödeme tipi için Core.Repository içerisinde class oluşturuldu.
- Ödeme tiplerinin implemente olduğu Ipayment interface oluşturuldu.
- Dependency Injection tasarım deseni kullanılarak IPayment özelliği olan DoPayment() methodu çağırıldı.
- AutoFac IoC framework ü kullanılarak Bootstrapper class ı içerisinde kullanacağımız ödeme tipini belirttik.
- Böylece binlerce farklı yerde değişiklik yapmak gerekse bile tek bir yerden müdahale ile değişiklik yapabileceğiz.
